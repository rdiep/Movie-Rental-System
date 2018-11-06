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
    public partial class CustomerLogin : Form
    {
        //customer ID to save
        public static int CID;
        // initialize connString
        string connString;
        // Connection string identifier USE FOR FUNCTIONS WITH CONNECTION STRING
        string connString1 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lukas\Desktop\CMPT-291-PROJECT\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
        string connString2 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ahmad\Desktop\git\CMPT-291-PROJECT\MovieRental\MovieRental\Database.mdf;Integrated Security=True";
        string connString3 = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Raymond\Desktop\CMPT291\MovieRental\MovieRental\Database.mdf;Integrated Security=True";

        public CustomerLogin()
        {
            InitializeComponent();
        }

        //login
        private void button1_Click(object sender, EventArgs e)
        {
            string customerUsername = "";
            string customerPassword = "";
            Boolean SQLCommand = true; //assumed to be nefarious SQL command entered as login unless proven otherwise
            SqlConnection conn;
            using (conn = ConnectionClass.getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    while (SQLCommand)
                    {
                        customerUsername = UsernameTextbox.Text;
                        customerPassword = PasswordTextbox.Text;
                        if ((customerUsername.Contains("SELECT ") || customerPassword.Contains("SELECT ")))
                        {
                            SQLCommand = true;
                            MessageBox.Show("SQL injection attempt rejected.");
                        }
                        else
                        {
                            SQLCommand = false;
                        }
                    }
                    comm.Connection = conn;
                    comm.CommandText = "SELECT * FROM CustomerData WHERE Username=@username AND Password=@password";
                    comm.Parameters.AddWithValue("@username", customerUsername);
                    comm.Parameters.AddWithValue("@password", customerPassword);
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                             CID = (int) dr[0];
                        }
                        MessageBox.Show("loginSuccess");
                        //need to send ID to next page.
                        this.Hide();
                        CustomerMainPage f1 = new CustomerMainPage();
                        f1.ShowDialog();
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("loginFail");
                        PasswordTextbox.Clear();
                    }
                    conn.Close();
                }
            }

        }

        //back
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f1 = new MainPage();
            f1.ShowDialog();
            this.Close();
        }

        private void CustomerLogin_Load(object sender, EventArgs e)
        {
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
    }
}
