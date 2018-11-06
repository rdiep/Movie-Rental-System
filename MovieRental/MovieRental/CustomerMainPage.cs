using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace MovieRental
{
    public partial class CustomerMainPage : Form
    {
        //title of movie they want to return, will be sent to rating page
        public static string movietitle;
        //cid of customer
        public static int CID;
        int actorid;
        public CustomerMainPage()
        {
            InitializeComponent();
            DatabaseGrid.ReadOnly = true;
            QueueGrid.ReadOnly = true;
            ActiveOrderGrid.ReadOnly = true;
            AllOrdersGrid.ReadOnly = true;
            BestSellerGrid.ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin f1 = new CustomerLogin();
            f1.ShowDialog();
            this.Close();

        }

        private void CustomerMainPage_Load(object sender, EventArgs e)
        {
            CustomerIDText.Text = CustomerLogin.CID.ToString();
            CID = CustomerLogin.CID;

            //Populate the moviedatabase with all movies automatically
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DatabaseGrid.DataSource = dt;
            //populate the custuomer info grid
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT Username, FirstName, LastName, City, State, ZIP, Phone, Email, CreditCardNum, Type FROM CustomerData WHERE CustomerID=" + CID, conn);
            dt = new DataTable();
            sda.Fill(dt);
            CustomerInfo.DataSource = dt;
            //populate the queue grid
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT MovieName, MovieData.MovieID, TimeAdded FROM Queue,MovieData WHERE MovieData.MovieID=Queue.MovieID AND Queue.CustomerID=" + CID + "ORDER BY TimeAdded ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            QueueGrid.DataSource = dt;
            //populate active orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, OrderDate FROM OrderData,MovieData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID=" + CID + " AND ReturnFlag = " + 0 + " ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            ActiveOrderGrid.DataSource = dt;
            //populate active orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, OrderDate FROM OrderData,MovieData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID=" + CID + " ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            AllOrdersGrid.DataSource = dt;
            //Populate best sellers
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"Select MovieData.MovieName, MovieData.MovieType FROM (SELECT OrderData.MovieID,COUNT(OrderID) as NumRentals FROM OrderData  GROUP BY OrderData.MovieID ) A, MovieData WHERE A.MovieID = MovieData.MovieID ORDER BY A.NumRentals DESC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            BestSellerGrid.DataSource = dt;
            //Populate actors
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"Select * FROM ActorData", conn);
            dt = new DataTable();
            sda.Fill(dt);
            Actor.DataSource = dt;
            //populate movie suggestions
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"select MovieName, MD.MovieType, MD.Rating
                from MovieData as MD, 
                    (select distinct MovieType
                    from OrderData as O, MovieData as M, CustomerData as C
                    where O.MovieID = M.MovieID and O.CustomerID LIKE '" + CID + "') as Q1 where MD.MovieType = Q1.MovieType" +
                    " EXCEPT select MovieName, M.MovieType, M.Rating from OrderData as O, MovieData as M where O.MovieID = M.MovieID", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddtoQueue_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.DatabaseGrid.SelectedRows.Count == 1)
            {
                DataRow row = (DatabaseGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "INSERT INTO Queue(MovieID,CustomerID,TimeAdded) VALUES(@val1, @val2, @val3)";
                        comm.Parameters.AddWithValue("@val1", row["MovieID"]);
                        comm.Parameters.AddWithValue("@val2", CID);
                        comm.Parameters.AddWithValue("@val3", DateTime.Now.ToString());
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Added to Queue");
                    }
                }
            }
            //repopulate grid view with new data
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT MovieName, MovieData.MovieID, TimeAdded FROM Queue,MovieData WHERE MovieData.MovieID=Queue.MovieID AND Queue.CustomerID=" + CID +"ORDER BY TimeAdded ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            QueueGrid.DataSource = dt;
        }

        private void DeleteQueue_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.QueueGrid.SelectedRows.Count > 0)
            {
                DataRow row = (QueueGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "DELETE FROM Queue WHERE MovieID = @val1 AND Queue.CustomerID = @val2 AND TimeAdded = @val3";
                        comm.Parameters.AddWithValue("@val1", row["MovieID"]);
                        comm.Parameters.AddWithValue("@val2", CID);
                        comm.Parameters.AddWithValue("@val3", row["TimeAdded"]);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully removed from Queue");
                    }
                }
            }
            //populate the queue grid
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT MovieName, MovieData.MovieID, TimeAdded FROM Queue,MovieData WHERE MovieData.MovieID=Queue.MovieID AND Queue.CustomerID=" + CID + "ORDER BY TimeAdded ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            QueueGrid.DataSource = dt;
        }

        //search by movie title
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MovieTitleTextbox.Text))
            {
                MessageBox.Show("Invalid Entry");
            }
            else
            {
                SqlConnection conn;
                string movietitle = "%" + MovieTitleTextbox.Text + "%";
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sda;
                sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID WHERE B.MovieName LIKE '" + movietitle + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseGrid.DataSource = dt;
            }
        }

        //genre search
        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(GenreTextbox.Text))
            {
                MessageBox.Show("Invalid Entry");
            }
            else
            {
                SqlConnection conn;
                string genre = "%" + GenreTextbox.Text + "%";
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sda;
                sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID WHERE B.MovieType LIKE '" + genre + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                DatabaseGrid.DataSource = dt;
            }
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.ActiveOrderGrid.SelectedRows.Count > 0)
            {
                DataRow row = (ActiveOrderGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        movietitle = (string) row["MovieName"];
                        this.Hide();
                        CustomerRateMovie f1 = new CustomerRateMovie();
                        f1.ShowDialog();
                        this.Show();
                        int? rating = CustomerRateMovie.rating;
                        comm.Connection = conn;
                        comm.CommandText = "UPDATE OrderData SET ActualDateReturn=@returndate, ReturnFlag=@flag, Rating=@rating WHERE OrderID = @val1";
                        comm.Parameters.AddWithValue("@val1", row["OrderID"]);
                        comm.Parameters.AddWithValue("@returndate", DateTime.Now.ToString());
                        comm.Parameters.AddWithValue("@flag", 1);
                        comm.Parameters.AddWithValue("@rating", rating);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully returned");
                    }
                }
            }
            //populate active orders
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, OrderDate FROM OrderData,MovieData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID=" + CID + " AND ReturnFlag = " + 0 + " ORDER BY OrderDate ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ActiveOrderGrid.DataSource = dt;
        }

        private void help(object sender, EventArgs e)
        {
            HelpMainPage f1 = new HelpMainPage();
            f1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(ActorText.Text))
            {
                MessageBox.Show("Invalid Entry");
            }
            else
            {
                SqlConnection conn;
                string actor = "%" + ActorText.Text + "%";
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sda;
                sda = new SqlDataAdapter(@"SELECT * FROM ActorData WHERE ActorName LIKE '" + actor + "'", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                Actor.DataSource = dt;
            }
        }

        private void Actor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Actor.SelectedRows.Count == 1)
            {
                DataRow row = (Actor.SelectedRows[0].DataBoundItem as DataRowView).Row;
                actorid = (int)row["ActorID"];

                //Update gridview when page is entered

                SqlConnection conn;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sqlda;
                sqlda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM Actin, (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID WHERE ActIn.ActorID="+actorid+" AND ActIn.MovieID=B.MovieID", conn);
                DataTable dtt = new DataTable();
                sqlda.Fill(dtt);
                DatabaseGrid.DataSource = dtt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ActorText.Clear();
            MovieTitleTextbox.Clear();
            GenreTextbox.Clear();
            //Populate the moviedatabase with all movies automatically
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            DatabaseGrid.DataSource = dt;
            //populate the custuomer info grid
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT Username, FirstName, LastName, City, State, ZIP, Phone, Email, CreditCardNum, Type FROM CustomerData WHERE CustomerID=" + CID, conn);
            dt = new DataTable();
            sda.Fill(dt);
            CustomerInfo.DataSource = dt;
            //populate the queue grid
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT MovieName, MovieData.MovieID, TimeAdded FROM Queue,MovieData WHERE MovieData.MovieID=Queue.MovieID AND Queue.CustomerID=" + CID + "ORDER BY TimeAdded ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            QueueGrid.DataSource = dt;
            //populate active orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, OrderDate FROM OrderData,MovieData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID=" + CID + " AND ReturnFlag = " + 0 + " ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            ActiveOrderGrid.DataSource = dt;
            //populate active orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, OrderDate FROM OrderData,MovieData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID=" + CID + " ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            AllOrdersGrid.DataSource = dt;
            //Populate best sellers
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"Select MovieData.MovieName, MovieData.MovieType FROM (SELECT OrderData.MovieID,COUNT(OrderID) as NumRentals FROM OrderData  GROUP BY OrderData.MovieID ) A, MovieData WHERE A.MovieID = MovieData.MovieID ORDER BY A.NumRentals DESC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            BestSellerGrid.DataSource = dt;
            //Populate actors
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"Select * FROM ActorData", conn);
            dt = new DataTable();
            sda.Fill(dt);
            Actor.DataSource = dt;
            //populate movie suggestions
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"select MovieName, MD.MovieType, MD.Rating
                from MovieData as MD, 
                    (select distinct MovieType
                    from OrderData as O, MovieData as M, CustomerData as C
                    where O.MovieID = M.MovieID and O.CustomerID LIKE '" + CID + "') as Q1 where MD.MovieType = Q1.MovieType" +
                    " EXCEPT select MovieName, M.MovieType, M.Rating from OrderData as O, MovieData as M where O.MovieID = M.MovieID", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
