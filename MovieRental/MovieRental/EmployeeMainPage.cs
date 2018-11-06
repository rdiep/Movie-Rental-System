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
    public partial class EmployeeMainPage : Form
    {
        public static int EID;
        public static int? CustomerID = null;

        public EmployeeMainPage()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f1 = new MainPage();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeAddEditCust f1 = new EmployeeAddEditCust();
            f1.ShowDialog();
            //this.Close();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeMailingList f1 = new EmployeeMailingList();
            f1.ShowDialog();
            //this.Close();
            this.Show();
        }

     

        private void EmployeeMainPage_Load(object sender, EventArgs e)
        {
            // initialize connString
            string connString;
            // Connection string identifier USE FOR FUNCTIONS WITH CONNECTION STRING
            string connString1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lukas\Desktop\CMPT-291-PROJECT\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
            string connString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ahmad\Desktop\git\CMPT-291-PROJECT\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
            string connString3 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Raymond\Desktop\CMPT291\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
            EID = EmployeeLogin.EID;
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
            ///////////////////////////////////////////////////////////
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MovieSuggestions f1 = new MovieSuggestions();
            f1.ShowDialog();
            //this.Close();
            this.Show();
        }
    }
}
