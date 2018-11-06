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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CustomerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerLogin f1 = new CustomerLogin();
            f1.ShowDialog();
            this.Close();
        }

        private void EmployeeLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeLogin f1 = new EmployeeLogin();
            f1.ShowDialog();
            this.Close();
        }

        private void ManagerLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerLogin f1 = new ManagerLogin();
            f1.ShowDialog();
            this.Close();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // initialize connString
            string connString;
            // Connection string identifier USE FOR FUNCTIONS WITH CONNECTION STRING
            string connString1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lukas\Desktop\CMPT-291-PROJECT\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
            string connString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ahmad\Desktop\git\CMPT-291-PROJECT\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
            string connString3 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Raymond\Desktop\CMPT291\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
            ///////////////////////////////////////////////////////////
            if (File.Exists("C:/Users/Lukas/Desktop/CMPT-291-PROJECT/MovieRental/MovieRental/Database.mdf"))
            {
                connString = connString1;
            }
            else if (File.Exists("C:/Users/Ahmad/Desktop/git/CMPT-291-PROJECT/MovieRental/MovieRental/Database.mdf"))
            {
                connString = connString2;
            }
            else if (File.Exists("D:/Raymond/Desktop/CMPT291/MovieRental/MovieRental/Database.mdf"))
            {
                connString = connString3;
            }
            else
            {
                System.Console.WriteLine("No DB file found!");
            }
            ///////////////////////////////////////////////////////////
        }
    }
}
