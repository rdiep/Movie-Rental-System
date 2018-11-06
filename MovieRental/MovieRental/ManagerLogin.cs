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
    public partial class ManagerLogin : Form
    {

        public static int MID;

        public ManagerLogin()
        {
            InitializeComponent();
        }

        //login button
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            using(conn = ConnectionClass.getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "SELECT * FROM ManagerData WHERE Username=@username AND Password=@password";
                    comm.Parameters.AddWithValue("@username", usernameField.Text);
                    comm.Parameters.AddWithValue("@password", passwordField.Text);
                    conn.Open();

                    SqlDataReader datareader = comm.ExecuteReader();

                    if (datareader.HasRows)
                    {
                        while (datareader.Read())
                        {
                            MID = (int)datareader[0];
                        }
                        MessageBox.Show("Login Successful");
                        //need to send ID to next page.
                        this.Hide();
                        ManagerMainPage f1 = new ManagerMainPage();
                        f1.ShowDialog();
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful");
                        passwordField.Clear();
                    }
                    conn.Close();
                }
            }
        }

        private void ManagerLogin_Load(object sender, EventArgs e)
        {
            // initialize connString
            string connString;
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
            else
            {
                connString = connString3;
            }
            ///////////////////////////////////////////////////////////
        }

        //back button
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f1 = new MainPage();
            f1.ShowDialog();
            this.Close();
        }
    }
}
