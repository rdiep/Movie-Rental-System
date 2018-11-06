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
    public partial class ManagerSalesReport : Form
    {
        public ManagerSalesReport()
        {
            InitializeComponent();
        }

        private void ManagerSalesReport_Load(object sender, EventArgs e)
        {
            //Populate sales per account type
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*25 as Income FROM CustomerData WHERE Type = 'Unlimited3' GROUP BY TYPE UNION Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*20 as Income FROM CustomerData WHERE Type = 'Unlimited2' GROUP BY TYPE UNION Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*15 as Income FROM CustomerData WHERE Type = 'Unlimited1' GROUP BY TYPE UNION Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*10 as Income FROM CustomerData WHERE Type = 'Limited' GROUP BY TYPE", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SalesReportGrid.DataSource = dt;
            //Populate total sale
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"SELECT SUM(A.NumberOfAccounts) as NumberOfAccounts, SUM(A.Income) as Income FROM (Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*25 as Income FROM CustomerData WHERE Type = 'Unlimited3' GROUP BY TYPE UNION Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*20 as Income FROM CustomerData WHERE Type = 'Unlimited2' GROUP BY TYPE UNION Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*15 as Income FROM CustomerData WHERE Type = 'Unlimited1' GROUP BY TYPE UNION Select TYPE, COUNT(CustomerID) as NumberOfAccounts, COUNT(CustomerID)*10 as Income FROM CustomerData WHERE Type = 'Limited' GROUP BY TYPE) A", conn);
            dt = new DataTable();
            sda.Fill(dt);
            TotalSalesGrid.DataSource = dt;
            //Populate pop movie
            String month = DateTime.Now.ToString("MM");
            conn = ConnectionClass.getConnection();   
            sda = new SqlDataAdapter(@"Select MovieData.MovieName, MovieData.MovieType, A.NumRentals FROM(SELECT OrderData.MovieID, COUNT(OrderID) as NumRentals FROM OrderData WHERE DATEPART(mm, OrderDate) = "+month+" GROUP BY OrderData.MovieID) A, MovieData WHERE A.MovieID = MovieData.MovieID ORDER BY A.NumRentals DESC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            PopMovie.DataSource = dt;
            //Populate top employee month 
            conn = ConnectionClass.getConnection();
            sda = new SqlDataAdapter(@"Select A.EmployeeID, EmployeeData.Username, EmployeeData.FirstName, EmployeeData.LastName, A.NumOrders FROM (SELECT OrderData.EmployeeID,COUNT(OrderID) as NumOrders FROM OrderData WHERE DATEPART(mm, OrderDate) = " + month + " GROUP BY OrderData.EmployeeID ) A, EmployeeData WHERE A.EmployeeID = EmployeeData.EmployeeID ORDER BY A.NumOrders DESC", conn);
            dt = new DataTable();
            sda.Fill(dt);
            TopEmployee.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
