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

    public partial class ManagerMoviePage : Form
    {
        int movieid;

        public ManagerMoviePage()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void ManagerMoviePage_Load(object sender, EventArgs e)
        {
            //Populate gridview when page is loaded
            SqlConnection conn = ConnectionClass.getConnection();
            //conn = new SqlConnection(connString);
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCopies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            string cmdString = "IF NOT EXISTS (Select * FROM MovieData WHERE MovieName=@val2) BEGIN INSERT INTO MovieData(MovieName, MovieType, NumCopies, Fee) VALUES (@val2, @val3, @val5, @val6)END ELSE BEGIN SELECT 1 END";


            SqlConnection conn;
            using (conn = ConnectionClass.getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    if (string.IsNullOrWhiteSpace(TitleTextbox.Text) || string.IsNullOrWhiteSpace(GenreTextbox.Text) || string.IsNullOrWhiteSpace(NumofCopiesTextbox.Text) || string.IsNullOrWhiteSpace(FeeTextbox.Text))
                    {
                        MessageBox.Show("Invalid Entry");
                        return;
                    }
                    else
                    {
                        comm.Connection = conn;
                        comm.CommandText = cmdString;
                        comm.Parameters.AddWithValue("@val2", TitleTextbox.Text);
                        comm.Parameters.AddWithValue("@val3", GenreTextbox.Text);
                        comm.Parameters.AddWithValue("@val5", NumofCopiesTextbox.Text);
                        comm.Parameters.AddWithValue("@val6", FeeTextbox.Text);
                        conn.Open();
                        SqlDataReader dr = comm.ExecuteReader();
                        if (dr.HasRows)
                        {
                            MessageBox.Show("MovieTitle Already Taken");
                        }
                        else
                        {
                            MessageBox.Show("Movie Added");
                        }
                        conn.Close();

                    }
                }
            }
            //Populate gridview when page is loaded
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        comm.CommandText = "DELETE FROM MovieData WHERE MovieID = " + row["MovieID"];
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Successfully Removed Movie");
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Movie");
            }
            //Populate gridview when page is loaded
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn); DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.dataGridView1.SelectedRows.Count == 1)
            {

                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        if (string.IsNullOrWhiteSpace(TitleTextbox.Text) || string.IsNullOrWhiteSpace(GenreTextbox.Text) || string.IsNullOrWhiteSpace(NumofCopiesTextbox.Text) || string.IsNullOrWhiteSpace(FeeTextbox.Text))
                        {
                            MessageBox.Show("Invalid Entry");
                            return;
                        }
                        else
                        {
                            comm.Connection = conn;
                            comm.CommandText = "IF NOT EXISTS (Select * FROM MovieData WHERE MovieName=@val2 and MovieID!=@val1) BEGIN UPDATE MovieData SET MovieName = @val2, MovieType = @val3, NumCopies = @val5, Fee = @val6  WHERE MovieID = @val1 END ELSE BEGIN SELECT 1 END";
                            comm.Parameters.AddWithValue("@val1", movieid);
                            comm.Parameters.AddWithValue("@val2", TitleTextbox.Text);
                            comm.Parameters.AddWithValue("@val3", GenreTextbox.Text);
                            comm.Parameters.AddWithValue("@val5", NumofCopiesTextbox.Text);
                            comm.Parameters.AddWithValue("@val6", FeeTextbox.Text);
                            conn.Open();
                            SqlDataReader dr = comm.ExecuteReader();
                            if (dr.HasRows)
                            {
                                MessageBox.Show("MovieTitle Already Taken");
                            }
                            else
                            {
                                MessageBox.Show("Movie Edited");
                            }
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Movie");
            }
            TitleTextbox.Clear();
            GenreTextbox.Clear();
            NumofCopiesTextbox.Clear();
            FeeTextbox.Clear();
            //Populate gridview when page is loaded
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCOpies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn); DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                movieid = (int)row["MovieID"];
                TitleTextbox.Text = (string)row["MovieName"];
                GenreTextbox.Text = (string)row["MovieType"];
                NumofCopiesTextbox.Text = (string)row["NumCopies"].ToString();
                FeeTextbox.Text = (string)row["Fee"].ToString();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string movietitle, genre, numcop, fee;
            movietitle = "%" + TitleTextbox.Text + "%";
            genre = "%" + GenreTextbox.Text + "%";
            numcop = "%" + NumofCopiesTextbox.Text + "%";
            fee = "%" + FeeTextbox.Text + "%";
            //populate active orders
            SqlConnection conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM MovieData WHERE MovieData.MovieType LIKE '" + genre + "' and MovieData.MovieName LIKE '" + movietitle + "' AND MovieData.NumCopies LIKE '" + numcop + "' AND MovieData.Fee LIKE '" + fee + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = ConnectionClass.getConnection();
            TitleTextbox.Clear();
            GenreTextbox.Clear();
            NumofCopiesTextbox.Clear();
            FeeTextbox.Clear();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT B.MovieID, B.MovieName, B.MovieType, A.Rating, B.NumCopies, B.Fee FROM (SELECT AVG(OrderData.Rating) as Rating, OrderData.MovieID FROM OrderData GROUP BY OrderData.MovieID) as A RIGHT JOIN MovieData as B ON A.MovieID=B.MovieID", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
