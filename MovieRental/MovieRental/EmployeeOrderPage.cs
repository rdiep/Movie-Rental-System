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
    public partial class EmployeeOrderPage : Form
    {
        public static int EID;
        public static int CID;
        public string AccountType;

        public EmployeeOrderPage()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
        }

        private void EmployeeOrderPage_Load(object sender, EventArgs e)
        {
            //get ID of employee
            EID = EmployeeAddEditCust.EID;
            //get customer CID from previous page
            CID = (int) EmployeeAddEditCust.CustomerID;
            ///////////////////////////////////////////////////////////
            //populate the info on the page
            SqlConnection conn;
            using (conn = ConnectionClass.getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "SELECT * FROM CustomerData WHERE CustomerID=@val";
                    comm.Parameters.AddWithValue("@val", CID);
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();
                    while (dr.Read())
                    {
                        ID.Text = dr[0].ToString();
                        FirstName.Text = dr[3].ToString();
                        LastName.Text = dr[4].ToString();
                        AccountType = dr[12].ToString();
                        Type.Text = dr[12].ToString();

                    }
                    conn.Close();
                }
            }
            //populate the queue grid
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT MovieData.MovieID, MovieName, TimeAdded FROM Queue,MovieData WHERE MovieData.MovieID=Queue.MovieID AND Queue.CustomerID=" + CID + "ORDER BY TimeAdded ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //populate active orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, OrderDate FROM OrderData,MovieData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID=" + CID + " AND ReturnFlag = " + 0 + " ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        //have to check if able to rent (LIMITED USER)
                        if (AccountType.Equals("Limited"))
                        {
                            int numofactive = dataGridView2.Rows.Count - 1;
                            //only 1 rental at a time for limited user
                            if (numofactive >= 1)
                            {
                                MessageBox.Show("Limit reached");
                                return;
                            }
                            String month = DateTime.Now.ToString("MM");
                            int monthlyorder = 0;
                            comm.Connection = conn;
                            //check how many rentals for current month
                            comm.CommandText = "SELECT COUNT(*) FROM OrderData WHERE CustomerID=" + CID + " AND DATEPART(mm, OrderDate)=@month";
                            comm.Parameters.AddWithValue("@month", month);
                            conn.Open();
                            SqlDataReader dr = comm.ExecuteReader();
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                    monthlyorder = (int)dr[0];
                                    MessageBox.Show(monthlyorder.ToString());
                                }
                                //if 2 or over, that is the limit 
                                if (monthlyorder >= 2)
                                {
                                    MessageBox.Show("Limit reached");
                                    return;
                                }
                            }
                            conn.Close();

                        }
                        else if (AccountType.Equals("Unlimited1"))
                        {
                            int numofactive = dataGridView2.Rows.Count - 1;
                            //only 1 rental at a time for unlimited1 user
                            if (numofactive >= 1)
                            {
                                MessageBox.Show("Limit reached");
                                return;
                            }
                        }
                        else if (AccountType.Equals("Unlimited2"))
                        {
                            int numofactive = dataGridView2.Rows.Count - 1;
                            //only 2 rental at a time for unlimited2 user
                            if (numofactive >= 2)
                            {
                                MessageBox.Show("Limit reached");
                                return;
                            }
                        }
                        else if (AccountType.Equals("Unlimited3"))
                        {
                            int numofactive = dataGridView2.Rows.Count - 1;
                            //only 3 rental at a time for unlimited3 user
                            if (numofactive >= 3)
                            {
                                MessageBox.Show("Limit reached");
                                return;
                            }
                        }
                        //check if there are any copies available in total
                        comm.Connection = conn;
                        comm.CommandText = "SELECT NumCopies FROM MovieData WHERE MovieID=@movieid";
                        comm.Parameters.AddWithValue("@movieid", row["MovieID"]);
                        conn.Open();
                        int totalcopies = 0;
                        SqlDataReader dr1 = comm.ExecuteReader();
                        if (dr1.HasRows)
                        {
                            while (dr1.Read())
                            {
                                totalcopies = (int)dr1[0];
                            }
                        }
                        conn.Close();
                        //check how many copies are being rented currently
                        comm.Connection = conn;
                        comm.CommandText = "SELECT COUNT(*) FROM OrderData WHERE ReturnFlag=@flag AND MovieID=@movieid1";
                        comm.Parameters.AddWithValue("@flag", 0);
                        comm.Parameters.AddWithValue("@movieid1", row["MovieID"]);
                        conn.Open();
                        int activecopies = 0;
                        dr1 = comm.ExecuteReader();
                        if (dr1.HasRows)
                        {
                            while (dr1.Read())
                            {
                                activecopies = (int)dr1[0];
                            }
                            //if the active copies are equal or greater, there is no stock left
                            if (activecopies >= totalcopies)
                            {
                                MessageBox.Show("No copies available");
                                return;
                            }
                        }
                        conn.Close();

                        //if made it to here, all good to go
                        comm.Connection = conn;
                        comm.CommandText = "INSERT INTO OrderData(MovieID,EmployeeID,CustomerID,OrderDate,ReturnFlag) VALUES(@val1, @val2, @val3, @val4, @val5)";
                        comm.Parameters.AddWithValue("@val1", row["MovieID"]);
                        comm.Parameters.AddWithValue("@val2", EID);
                        comm.Parameters.AddWithValue("@val3", CID);
                        comm.Parameters.AddWithValue("@val4", DateTime.Now.ToString());
                        comm.Parameters.AddWithValue("@val5", 0);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        comm.Connection = conn;
                        comm.CommandText = "DELETE FROM Queue WHERE MovieID = @val11 AND CustomerID =  @val22 AND TimeAdded = @val33";
                        comm.Parameters.AddWithValue("@val11", row["MovieID"]);
                        comm.Parameters.AddWithValue("@val22", CID);
                        comm.Parameters.AddWithValue("@val33", row["TimeAdded"]);
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Order created");
                    }
                }
            }
            //populate the queue grid
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT MovieData.MovieID, MovieName, TimeAdded FROM Queue,MovieData WHERE MovieData.MovieID=Queue.MovieID AND Queue.CustomerID=" + CID + "ORDER BY TimeAdded ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            //populate active orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, OrderDate FROM OrderData,MovieData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID=" + CID + " AND ReturnFlag = " + 0 + " ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        //back button
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
