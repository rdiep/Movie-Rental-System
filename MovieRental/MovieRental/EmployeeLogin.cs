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
    public partial class EmployeeLogin : Form
    {
        //EID employee id
        public static int EID;

        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainPage f1 = new MainPage();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            using (conn = ConnectionClass.getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    comm.Connection = conn;
                    comm.CommandText = "SELECT * FROM EmployeeData WHERE Username=@username AND Password=@password";
                    comm.Parameters.AddWithValue("@username", UsernameTextbox.Text);
                    comm.Parameters.AddWithValue("@password", PasswordTextbox.Text);
                    conn.Open();
                    SqlDataReader dr = comm.ExecuteReader();

                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            EID = (int)dr[0];
                        }
                        MessageBox.Show("Login Successful");
                        //need to send ID to next page.
                        this.Hide();
                        EmployeeMainPage f1 = new EmployeeMainPage();
                        f1.ShowDialog();
                        conn.Close();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login Unsuccessful");
                        PasswordTextbox.Clear();
                    }
                    conn.Close();
                }
            }
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
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
    }
}
