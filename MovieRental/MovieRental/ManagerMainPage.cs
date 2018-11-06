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
    public partial class ManagerMainPage : Form
    {
        public ManagerMainPage()
        {
            InitializeComponent();
            TopMovieGrid.ReadOnly = true;
            TopCustomerGrid.ReadOnly = true;
            TopEmployeeGrid.ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f1 = new MainPage();
            f1.ShowDialog();
            this.Close();
        }

        private void MovieButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerMoviePage f1 = new ManagerMoviePage();
            f1.ShowDialog();
            this.Show();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerEmployeePage f1 = new ManagerEmployeePage();
            f1.ShowDialog();
            this.Show();
        }

        private void ManagerMainPage_Load(object sender, EventArgs e)
        {
            //Populate top employees
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"Select A.EmployeeID, EmployeeData.Username, EmployeeData.FirstName, EmployeeData.LastName, A.NumOrders FROM (SELECT OrderData.EmployeeID,COUNT(OrderID) as NumOrders FROM OrderData  GROUP BY OrderData.EmployeeID ) A, EmployeeData WHERE A.EmployeeID = EmployeeData.EmployeeID ORDER BY A.NumOrders DESC", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TopEmployeeGrid.DataSource = dt;
            //Populate top customers
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"Select A.CustomerID, CustomerData.Username, CustomerData.FirstName, CustomerData.LastName, A.NumRentals FROM (SELECT OrderData.CustomerID,COUNT(OrderID) as NumRentals FROM OrderData  GROUP BY OrderData.CustomerID ) A, CustomerData WHERE A.CustomerID = CustomerData.CustomerID ORDER BY A.NumRentals DESC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            TopCustomerGrid.DataSource = dt;
            //Populate top movie
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"Select A.MovieID, MovieData.MovieName, MovieData.MovieType, A.NumRentals FROM (SELECT OrderData.MovieID,COUNT(OrderID) as NumRentals FROM OrderData  GROUP BY OrderData.MovieID ) A, MovieData WHERE A.MovieID = MovieData.MovieID ORDER BY A.NumRentals DESC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            TopMovieGrid.DataSource = dt;
        }

        private void RentalButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerRental f1 = new ManagerRental();
            f1.ShowDialog();
            this.Show();
        }

        private void SalesReportButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerSalesReport f1 = new ManagerSalesReport();
            f1.ShowDialog();
            this.Show();
        }

        private void actorButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ActorPage f1 = new ActorPage();
            f1.ShowDialog();
            this.Show();
        }
    }
}