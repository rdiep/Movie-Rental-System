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
    public partial class ManagerRental : Form
    {
        public ManagerRental()
        {
            InitializeComponent();
            ActiveGrid.ReadOnly = true;
            TotalGrid.ReadOnly = true;
        }

        private void ManagerRental_Load(object sender, EventArgs e)
        {
            //populate active orders
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, MovieType, OrderDate, FirstName, LastName FROM OrderData,MovieData,CustomerData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID = CustomerData.CustomerID AND ReturnFlag = " + 0 + " ORDER BY OrderDate ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ActiveGrid.DataSource = dt;
            //populate total orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, MovieType, OrderDate, FirstName, LastName FROM OrderData,MovieData,CustomerData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID = CustomerData.CustomerID ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            TotalGrid.DataSource = dt;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string movietitle, genre, firstname, lastname;
            movietitle = "%" + TitleTextbox.Text + "%";
            genre = "%" + GenreTextbox.Text + "%";
            firstname = "%" + FirstNameTextBox.Text + "%";
            lastname = "%" + LastNameTextBox.Text + "%";
            //populate active orders
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, MovieType, OrderDate, FirstName, LastName FROM OrderData, MovieData,CustomerData WHERE MovieData.MovieID = OrderData.MovieID AND CustomerData.CustomerID = OrderData.CustomerID AND ReturnFlag = " + 0 + " AND MovieData.MovieType LIKE '" + genre + "' and MovieData.MovieName LIKE '" + movietitle + "' AND CustomerData.FirstName LIKE '" + firstname + "' AND CustomerData.LastName LIKE '" + lastname + "' ORDER BY OrderDate ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ActiveGrid.DataSource = dt;
            //populate total orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, MovieType, OrderDate, FirstName, LastName FROM OrderData, MovieData,CustomerData WHERE MovieData.MovieID = OrderData.MovieID AND CustomerData.CustomerID = OrderData.CustomerID AND MovieData.MovieType LIKE '" + genre + "' and MovieData.MovieName LIKE '" + movietitle + "' AND CustomerData.FirstName LIKE '" + firstname + "' AND CustomerData.LastName LIKE '" + lastname + "' ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            TotalGrid.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TitleTextbox.Clear();
            GenreTextbox.Clear();
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            //populate active orders
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, MovieType, OrderDate, FirstName, LastName FROM OrderData,MovieData,CustomerData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID = CustomerData.CustomerID AND ReturnFlag = " + 0 + " ORDER BY OrderDate ASC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ActiveGrid.DataSource = dt;
            //populate total orders
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT OrderID, MovieName, MovieType, OrderDate, FirstName, LastName FROM OrderData,MovieData,CustomerData WHERE MovieData.MovieID=OrderData.MovieID AND OrderData.CustomerID = CustomerData.CustomerID ORDER BY OrderDate ASC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            TotalGrid.DataSource = dt;
        }
    }
}
