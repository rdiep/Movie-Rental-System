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
    public partial class EmployeeAddEditCust : Form
    {
        int? cid=null;
        public static int? CustomerID = null;
        public static int EID;

        public EmployeeAddEditCust()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
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
                        if (string.IsNullOrWhiteSpace(UsernameTextbox.Text) || string.IsNullOrWhiteSpace(PasswordTextbox.Text) || string.IsNullOrWhiteSpace(FirstnameTextbox.Text) || string.IsNullOrWhiteSpace(LastnameTextbox.Text) || string.IsNullOrWhiteSpace(CityTextbox.Text) || string.IsNullOrWhiteSpace(StateTextbox.Text) || string.IsNullOrWhiteSpace(ZIPTextbox.Text) || string.IsNullOrWhiteSpace(PhoneTextbox.Text) || string.IsNullOrWhiteSpace(EmailTextbox.Text) || string.IsNullOrWhiteSpace(CCTextbox.Text) || string.IsNullOrWhiteSpace(AccountTypeCombobox.Text))
                        {
                            MessageBox.Show("Invalid Entry");
                            return;
                        }
                        else
                        {
                            comm.Connection = conn;
                            comm.CommandText = "IF NOT EXISTS (Select * FROM CustomerData WHERE USERNAME=@val2 AND CustomerID!=@val1) BEGIN UPDATE CustomerData SET Username = @val2, Password = @val3, Firstname = @val4, Lastname = @val5, City = @val6, State = @val7, ZIP = @val8, Phone = @val9, Email = @val10, CreditCardNum = @val12, Type = @val13  WHERE CustomerID = @val1  END ELSE BEGIN SELECT 1 END";
                            comm.Parameters.AddWithValue("@val1", cid);
                            comm.Parameters.AddWithValue("@val2", UsernameTextbox.Text);
                            comm.Parameters.AddWithValue("@val3", PasswordTextbox.Text);
                            comm.Parameters.AddWithValue("@val4", FirstnameTextbox.Text);
                            comm.Parameters.AddWithValue("@val5", LastnameTextbox.Text);
                            comm.Parameters.AddWithValue("@val6", CityTextbox.Text);
                            comm.Parameters.AddWithValue("@val7", StateTextbox.Text);
                            comm.Parameters.AddWithValue("@val8", ZIPTextbox.Text);
                            comm.Parameters.AddWithValue("@val9", PhoneTextbox.Text);
                            comm.Parameters.AddWithValue("@val10", EmailTextbox.Text);
                            comm.Parameters.AddWithValue("@val12", CCTextbox.Text);
                            comm.Parameters.AddWithValue("@val13", AccountTypeCombobox.Text);
                            conn.Open();
                            SqlDataReader dr = comm.ExecuteReader();

                            if (dr.HasRows)
                            {
                                MessageBox.Show("Username Already Taken");
                            }
                            else
                            {
                                MessageBox.Show("Customer Edited");
                            }
                            conn.Close();
                        }


                    }
                }
            }
            else
            {
                MessageBox.Show("Select Customer");
            }
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
            FirstnameTextbox.Clear();
            LastnameTextbox.Clear();
            CityTextbox.Clear();
            StateTextbox.Clear();
            ZIPTextbox.Clear();
            PhoneTextbox.Clear();
            EmailTextbox.Clear();
            CCTextbox.Clear();
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM CustomerData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                    if (string.IsNullOrWhiteSpace(UsernameTextbox.Text) || string.IsNullOrWhiteSpace(PasswordTextbox.Text) || string.IsNullOrWhiteSpace(FirstnameTextbox.Text) || string.IsNullOrWhiteSpace(LastnameTextbox.Text) || string.IsNullOrWhiteSpace(CityTextbox.Text) || string.IsNullOrWhiteSpace(StateTextbox.Text) || string.IsNullOrWhiteSpace(ZIPTextbox.Text) || string.IsNullOrWhiteSpace(PhoneTextbox.Text) || string.IsNullOrWhiteSpace(EmailTextbox.Text) || string.IsNullOrWhiteSpace(CCTextbox.Text) || string.IsNullOrWhiteSpace(AccountTypeCombobox.Text))
                    {
                        MessageBox.Show("Invalid Entry");
                        return;
                    }
                    else
                    {
                        comm.Connection = conn;
                        comm.CommandText = "IF NOT EXISTS (Select * FROM CustomerData WHERE USERNAME=@val2) BEGIN INSERT INTO CustomerData(Username, Password, FirstName, LastName, City, State, ZIP, Phone, Email, AccountCreatedDate, CreditCardNum, Type) VALUES (@val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11, @val12, @val13) END ELSE BEGIN SELECT 1 END";
                        comm.Parameters.AddWithValue("@val2", UsernameTextbox.Text);
                        comm.Parameters.AddWithValue("@val3", PasswordTextbox.Text);
                        comm.Parameters.AddWithValue("@val4", FirstnameTextbox.Text);
                        comm.Parameters.AddWithValue("@val5", LastnameTextbox.Text);
                        comm.Parameters.AddWithValue("@val6", CityTextbox.Text);
                        comm.Parameters.AddWithValue("@val7", StateTextbox.Text);
                        comm.Parameters.AddWithValue("@val8", ZIPTextbox.Text);
                        comm.Parameters.AddWithValue("@val9", PhoneTextbox.Text);
                        comm.Parameters.AddWithValue("@val10", EmailTextbox.Text);
                        comm.Parameters.AddWithValue("@val11", DateTime.Now.ToString());
                        comm.Parameters.AddWithValue("@val12", CCTextbox.Text);
                        comm.Parameters.AddWithValue("@val13", AccountTypeCombobox.Text);
                        conn.Open();
                        SqlDataReader dr = comm.ExecuteReader();

                        if (dr.HasRows)
                        {
                            MessageBox.Show("Username Already Taken");
                        }
                        else
                        {
                            MessageBox.Show("Customer Added");
                        }
                        conn.Close();
                    }
                    }
                }
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM CustomerData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
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
                        comm.CommandText = "DELETE FROM CustomerData WHERE CustomerID = " + row["CustomerID"];
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Deleted Customer");
                    }
                }
            }
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM CustomerData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void EmployeeAddEditCust_Load(object sender, EventArgs e)
        {
            //get ID of employee
            EID = EmployeeMainPage.EID;
            dataGridView1.ReadOnly = true;
            //Populate gridview when page is loaded
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM CustomerData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                cid = (int)row["CustomerID"];
                UsernameTextbox.Text = (string)row["Username"];
                PasswordTextbox.Text = (string)row["Password"];
                FirstnameTextbox.Text = (string)row["FirstName"];
                LastnameTextbox.Text = (string)row["LastName"];
                CityTextbox.Text = (string)row["City"];
                StateTextbox.Text = (string)row["State"];
                ZIPTextbox.Text = (string)row["ZIP"].ToString();
                PhoneTextbox.Text = (string)row["Phone"].ToString();
                EmailTextbox.Text = (string)row["Email"];
                CCTextbox.Text = (string)row["CreditCardNum"].ToString();
                AccountTypeCombobox.Text = (string)row["Type"];
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string username, password, firstname, lastname, city, state, zip, phone, email, cc, type;
            username = "%" + UsernameTextbox.Text + "%";
            password = "%" + PasswordTextbox.Text + "%";
            firstname = "%" + FirstnameTextbox.Text + "%";
            lastname = "%" + LastnameTextbox.Text + "%";
            email = "%" + EmailTextbox.Text + "%";
            city = "%" + CityTextbox.Text + "%";
            state = "%" + StateTextbox.Text + "%";
            zip = "%" + ZIPTextbox.Text + "%";
            phone = "%" + PhoneTextbox.Text + "%";
            cc = "%" + CCTextbox.Text + "%";
            type = "%" + AccountTypeCombobox.Text + "%";
            //populate active orders
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM CustomerData WHERE CustomerData.Username LIKE '" + username + "' and CustomerData.Password LIKE '" + password + "' AND CustomerData.FirstName LIKE '" + firstname + "' AND CustomerData.LastName LIKE '" + lastname + "'and CustomerData.City LIKE '" + city + "' AND CustomerData.State LIKE '" + state + "' AND CustomerData.ZIP LIKE '" + zip + "'AND CustomerData.CreditCardNum LIKE '" + cc + "' AND CustomerData.Phone LIKE '" + phone + "'AND CustomerData.Type LIKE '" + type + "' AND CustomerData.Email LIKE '" + email + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //create order page
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 1)
            {
                DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                cid = (int)row["CustomerID"];
                CustomerID = (int)row["CustomerID"];
                string CustomerUsername;
                CustomerUsername = (string)row["Username"];
                SqlConnection conn;
                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        comm.Connection = conn;
                        SqlDataReader myreader;
                        comm.CommandText = "SELECT TOP 1 CustomerID FROM CustomerData WHERE Username = @val1";
                        comm.Parameters.AddWithValue("@val1", CustomerUsername);
                        conn.Open();
                        myreader = comm.ExecuteReader();
                        while (myreader.Read())
                        {
                            CustomerID = (int)myreader[0];
                        }
                        if (CustomerID != null)
                        {
                            this.Hide();
                            EmployeeOrderPage f1 = new EmployeeOrderPage();
                            f1.ShowDialog();
                            //this.Close();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Username");
                        }
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Customer");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
            FirstnameTextbox.Clear();
            LastnameTextbox.Clear();
            CityTextbox.Clear();
            StateTextbox.Clear();
            ZIPTextbox.Clear();
            PhoneTextbox.Clear();
            EmailTextbox.Clear();
            CCTextbox.Clear();
            //get ID of employee
            EID = EmployeeMainPage.EID;
            dataGridView1.ReadOnly = true;
            //Populate gridview when page is loaded
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM CustomerData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
