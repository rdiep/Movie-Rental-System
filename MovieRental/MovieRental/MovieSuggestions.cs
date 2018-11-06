using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class MovieSuggestions : Form
    {

        public MovieSuggestions()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Invalid Entry");
            }
            else
            {
                SqlConnection conn;
                string username = textBox1.Text;
                conn = ConnectionClass.getConnection();
                SqlDataAdapter sda;
                sda = new SqlDataAdapter(@"select MovieName, MD.MovieType, MD.Rating
                from MovieData as MD, 
                    (select distinct MovieType
                    from OrderData as O, MovieData as M, CustomerData as C
                    where O.MovieID = M.MovieID and O.CustomerID = C.CustomerID and Username LIKE '" + username + "') as Q1 where MD.MovieType = Q1.MovieType" +
                    " EXCEPT select MovieName, M.MovieType, M.Rating from OrderData as O, MovieData as M where O.MovieID = M.MovieID", conn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void MovieSuggestions_Load(object sender, EventArgs e)
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
            ///////////////////////////////////////////////////////////
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeMainPage f1 = new EmployeeMainPage();
            f1.ShowDialog();
            this.Close();
        }
    }
}
