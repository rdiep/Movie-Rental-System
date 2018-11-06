using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieRental
{
    public partial class ActorPage : Form
    {
        int actorid,movieid;
        public ActorPage()
        {
            InitializeComponent();
            actorInfoGrid.ReadOnly = true;
        }

        private void actor_back_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMainPage f1 = new ManagerMainPage();
            f1.ShowDialog();
            this.Close();
        }

        private void ActorPage_Load(object sender, EventArgs e)
        {
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT ActorData.ActorID, ActorData.ActorName, ActorData.Gender, ActorData.Age FROM ActorData", conn);
            DataTable actorDataTable = new DataTable();
            sda.Fill(actorDataTable);
            actorInfoGrid.DataSource = actorDataTable;
            //Populate gridview when page is loaded
            conn = ConnectionClass.getConnection();
            //conn = new SqlConnection(connString);
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCopies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Movies.DataSource = dt;
        }

        private void actorEditButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.actorInfoGrid.SelectedRows.Count == 1)
            {
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        if(string.IsNullOrWhiteSpace(NameTextbox.Text) || string.IsNullOrWhiteSpace(GenderTextbox.Text) || string.IsNullOrWhiteSpace(AgeTextbox.Text))
                        {
                            MessageBox.Show("Invalid Entry");
                            return;
                        }
                        else
                        {
                            comm.Connection = conn;
                            comm.CommandText = "IF NOT EXISTS (Select * FROM ActorData where ActorName = @val1 and ActorID!=@val0) BEGIN UPDATE ActorData SET ActorName = @val1, Gender = @val2, Age = @val3 WHERE ActorID = @val0 END ELSE BEGIN SELECT 1 END";
                            comm.Parameters.AddWithValue("@val0", actorid);
                            comm.Parameters.AddWithValue("@val1", NameTextbox.Text);
                            comm.Parameters.AddWithValue("@val2", GenderTextbox.Text);
                            comm.Parameters.AddWithValue("@val3", AgeTextbox.Text);

                            conn.Open();
                            SqlDataReader dtr = comm.ExecuteReader();
                            if (dtr.HasRows)
                            {
                                MessageBox.Show("Actor Name Already Being Used in DB!");
                            }
                            else
                            {
                                MessageBox.Show("Actor Edited Successfully");
                            }
                            conn.Close();

                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Actor");
            }
            NameTextbox.Clear();
            GenderTextbox.Clear();
            AgeTextbox.Clear();
            //Update gridview when page is entered
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sqlda;
            sqlda = new SqlDataAdapter(@"SELECT * FROM ActorData", conn);
            DataTable dtt = new DataTable();
            sqlda.Fill(dtt);
            actorInfoGrid.DataSource = dtt;
        }

        private void actorAddButton_Click(object sender, EventArgs e)
        {
            string cmdString = "IF NOT EXISTS (Select * From ActorData WHERE ActorName=@val1) BEGIN INSERT INTO ActorData(ActorName, Gender, Age) VALUES (@val1, @val2, @val3)END ELSE BEGIN SELECT 1 END";

            SqlConnection conn;
            using (conn = ConnectionClass.getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    if (string.IsNullOrWhiteSpace(NameTextbox.Text) || string.IsNullOrWhiteSpace(GenderTextbox.Text) || string.IsNullOrWhiteSpace(AgeTextbox.Text))
                    {
                        MessageBox.Show("Invalid Entry!");
                        return;
                    }
                    else
                    {
                        comm.Connection = conn;
                        comm.CommandText = cmdString;
                        comm.Parameters.AddWithValue("@val1", NameTextbox.Text);
                        comm.Parameters.AddWithValue("@val2", GenderTextbox.Text);
                        comm.Parameters.AddWithValue("@val3", AgeTextbox.Text);

                        conn.Open();
                        SqlDataReader dtr = comm.ExecuteReader();
                        if (dtr.HasRows)
                        {
                            MessageBox.Show("Actor Name Already Being Used in DB!");
                        }
                        else
                        {
                            MessageBox.Show("Actor Added Successfully");
                        }
                        conn.Close();
                    }
                }
            }
            //Update gridview when page is entered
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sqlda;
            sqlda = new SqlDataAdapter(@"SELECT * FROM ActorData", conn);
            DataTable dtt = new DataTable();
            sqlda.Fill(dtt);
            actorInfoGrid.DataSource = dtt;
        }

        private void actorSearchButton_Click(object sender, EventArgs e)
        {
            string actorname, gender, age;
            actorname = "%" + NameTextbox.Text + "%";
            gender = "%" + GenderTextbox.Text + "%";
            age = "%" + AgeTextbox.Text + "%";
            //populate active orders
            SqlConnection conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM ActorData WHERE ActorData.ActorName LIKE '" + actorname + "' and ActorData.Gender LIKE '" + gender + "' AND ActorData.Age LIKE '" + age + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            actorInfoGrid.DataSource = dt;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.actorInfoGrid.SelectedRows.Count == 1)
            {
                DataRow row = (actorInfoGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
                using (conn= ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "DELETE FROM ActorData WHERE ActorID = " + row["ActorID"];
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully Removed Actor");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Actor");
            }
            //Update gridview when page is entered
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sqlda;
            sqlda = new SqlDataAdapter(@"SELECT * FROM ActorData", conn);
            DataTable dtt = new DataTable();
            sqlda.Fill(dtt);
            actorInfoGrid.DataSource = dtt;
        }

        private void actorInfoGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.actorInfoGrid.SelectedRows.Count == 1)
            {
                DataRow row = (actorInfoGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
                actorid = (int)row["ActorID"];
                NameTextbox.Text = (string)row["ActorName"];
                GenderTextbox.Text = (string)row["Gender"];
                AgeTextbox.Text = (string)row["Age"].ToString();

                //Update gridview when page is entered

                SqlConnection conn;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sqlda;
                sqlda = new SqlDataAdapter(@"SELECT MovieName, MovieType, Rating FROM ActIn,MovieData WHERE ActIn.ActorID=" + actorid +" AND MovieData.MovieID=ActIn.MovieID", conn);
                DataTable dtt = new DataTable();
                sqlda.Fill(dtt);
                Actin.DataSource = dtt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string movietitle, genre;
            movietitle = "%" + MovieTitle.Text + "%";
            genre = "%" + Genre.Text + "%";
            //populate active orders
            SqlConnection conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM MovieData WHERE MovieData.MovieType LIKE '" + genre + "' and MovieData.MovieName LIKE '" + movietitle + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Movies.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Movies.SelectedRows.Count == 1 && this.actorInfoGrid.SelectedRows.Count ==1)
            {
                string cmdString = "IF NOT EXISTS (Select * From ActIn WHERE MovieID=@val1 AND ActorID=@val2) BEGIN INSERT INTO ActIn(MovieID, ActorID) VALUES (@val1, @val2)END ELSE BEGIN SELECT 1 END";
                SqlConnection conn;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                            comm.Connection = conn;
                            comm.CommandText = cmdString;
                            comm.Parameters.AddWithValue("@val1", movieid);
                            comm.Parameters.AddWithValue("@val2", actorid);

                            conn.Open();
                            SqlDataReader dtr = comm.ExecuteReader();
                            if (dtr.HasRows)
                            {
                                MessageBox.Show("Actor Already in Movie!");
                            }
                            else
                            {
                                MessageBox.Show("Actor Added Successfully");
                            }
                            conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Movie and Actor");
            }

            if (this.Movies.SelectedRows.Count == 1)
            {
                DataRow row = (Movies.SelectedRows[0].DataBoundItem as DataRowView).Row;
                movieid = (int)row["MovieID"];

                //Update gridview when page is entered

                SqlConnection conn;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sqlda;
                sqlda = new SqlDataAdapter(@"SELECT ActorName, Gender, Age FROM ActIn,ActorData WHERE ActIn.MovieID=" + movieid + " AND ActorData.ActorID=ActIn.ActorID", conn);
                DataTable dtt = new DataTable();
                sqlda.Fill(dtt);
                Actorinmovies.DataSource = dtt;
            }
            if (this.actorInfoGrid.SelectedRows.Count == 1)
            {
                DataRow row = (actorInfoGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
                actorid = (int)row["ActorID"];
                NameTextbox.Text = (string)row["ActorName"];
                GenderTextbox.Text = (string)row["Gender"];
                AgeTextbox.Text = (string)row["Age"].ToString();

                //Update gridview when page is entered

                SqlConnection conn;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sqlda;
                sqlda = new SqlDataAdapter(@"SELECT MovieName, MovieType, Rating FROM ActIn,MovieData WHERE ActIn.ActorID=" + actorid + " AND MovieData.MovieID=ActIn.MovieID", conn);
                DataTable dtt = new DataTable();
                sqlda.Fill(dtt);
                Actin.DataSource = dtt;
            }
        }

        //remove actor from movie
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.Movies.SelectedRows.Count == 1 && this.actorInfoGrid.SelectedRows.Count == 1)
            {
                string cmdString = "IF EXISTS (Select * From ActIn WHERE MovieID=@val1 AND ActorID=@val2) BEGIN DELETE FROM ActIn WHERE MovieID=@val1 AND ActorID=@val2 END ELSE BEGIN SELECT 1 END";
                SqlConnection conn;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = cmdString;
                        comm.Parameters.AddWithValue("@val1", movieid);
                        comm.Parameters.AddWithValue("@val2", actorid);

                        conn.Open();
                        SqlDataReader dtr = comm.ExecuteReader();
                        if (dtr.HasRows)
                        {
                            MessageBox.Show("Actor not in that Movie!");
                        }
                        else
                        {
                            MessageBox.Show("Actor removed from Movie");
                        }
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Movie and Actor");
            }

            if (this.Movies.SelectedRows.Count == 1)
            {
                DataRow row = (Movies.SelectedRows[0].DataBoundItem as DataRowView).Row;
                movieid = (int)row["MovieID"];

                //Update gridview when page is entered

                SqlConnection conn;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sqlda;
                sqlda = new SqlDataAdapter(@"SELECT ActorName, Gender, Age FROM ActIn,ActorData WHERE ActIn.MovieID=" + movieid + " AND ActorData.ActorID=ActIn.ActorID", conn);
                DataTable dtt = new DataTable();
                sqlda.Fill(dtt);
                Actorinmovies.DataSource = dtt;
            }
            if (this.actorInfoGrid.SelectedRows.Count == 1)
            {
                DataRow row = (actorInfoGrid.SelectedRows[0].DataBoundItem as DataRowView).Row;
                actorid = (int)row["ActorID"];
                NameTextbox.Text = (string)row["ActorName"];
                GenderTextbox.Text = (string)row["Gender"];
                AgeTextbox.Text = (string)row["Age"].ToString();

                //Update gridview when page is entered

                SqlConnection conn;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sqlda;
                sqlda = new SqlDataAdapter(@"SELECT MovieName, MovieType, Rating FROM ActIn,MovieData WHERE ActIn.ActorID=" + actorid + " AND MovieData.MovieID=ActIn.MovieID", conn);
                DataTable dtt = new DataTable();
                sqlda.Fill(dtt);
                Actin.DataSource = dtt;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NameTextbox.Clear();
            GenderTextbox.Clear();
            AgeTextbox.Clear();
            MovieTitle.Clear();
            Genre.Clear();

            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT ActorData.ActorID, ActorData.ActorName, ActorData.Gender, ActorData.Age FROM ActorData", conn);
            DataTable actorDataTable = new DataTable();
            sda.Fill(actorDataTable);
            actorInfoGrid.DataSource = actorDataTable;
            //Populate gridview when page is loaded
            conn = ConnectionClass.getConnection();
            //conn = new SqlConnection(connString);
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCopies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            Movies.DataSource = dt;

            Actin.Columns.Clear();
            Actorinmovies.Columns.Clear();
        }

        private void Movies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.Movies.SelectedRows.Count == 1)
            {
                DataRow row = (Movies.SelectedRows[0].DataBoundItem as DataRowView).Row;
                movieid = (int)row["MovieID"];

                //Update gridview when page is entered

                SqlConnection conn;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sqlda;
                sqlda = new SqlDataAdapter(@"SELECT ActorName, Gender, Age FROM ActIn,ActorData WHERE ActIn.MovieID=" + movieid + " AND ActorData.ActorID=ActIn.ActorID", conn);
                DataTable dtt = new DataTable();
                sqlda.Fill(dtt);
                Actorinmovies.DataSource = dtt;
            }
        }
    }
}
