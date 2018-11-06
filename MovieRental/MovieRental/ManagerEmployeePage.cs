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
    public partial class ManagerEmployeePage : Form
    {
        int eid;

        public ManagerEmployeePage()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void ManagerEmployeePage_Load(object sender, EventArgs e)
        {
            //Populate gridview when page is loaded
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM EmployeeData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }


        //edit employee
        private void EditButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            if (this.dataGridView1.SelectedRows.Count == 1)
            {

                using (conn = ConnectionClass.getConnection())
                {
                    using (SqlCommand comm = new SqlCommand())
                    {
                        if (string.IsNullOrWhiteSpace(UsernameTextbox.Text) || string.IsNullOrWhiteSpace(PasswordTextbox.Text) || string.IsNullOrWhiteSpace(FirstnameTextbox.Text) || string.IsNullOrWhiteSpace(LastnameTextbox.Text) || string.IsNullOrWhiteSpace(CityTextbox.Text) || string.IsNullOrWhiteSpace(StateTextbox.Text) || string.IsNullOrWhiteSpace(ZIPTextbox.Text) || string.IsNullOrWhiteSpace(PhoneTextbox.Text) || string.IsNullOrWhiteSpace(HourlywageTextbox.Text))
                        {
                            MessageBox.Show("Invalid Entry");
                            return;
                        }
                        else
                        {
                            comm.Connection = conn;
                            comm.CommandText = "IF NOT EXISTS (Select * FROM EmployeeData WHERE USERNAME=@val2 and EmployeeID!=@val1) BEGIN UPDATE EmployeeData SET Username = @val2, Password = @val3, Firstname = @val4, Lastname = @val5, City = @val6, State = @val7, ZIP = @val8, Phone = @val9, HourlyWage = @val11  WHERE EmployeeID = @val1 END ELSE BEGIN SELECT 1 END";
                            comm.Parameters.AddWithValue("@val1", eid);
                            comm.Parameters.AddWithValue("@val2", UsernameTextbox.Text);
                            comm.Parameters.AddWithValue("@val3", PasswordTextbox.Text);
                            comm.Parameters.AddWithValue("@val4", FirstnameTextbox.Text);
                            comm.Parameters.AddWithValue("@val5", LastnameTextbox.Text);
                            comm.Parameters.AddWithValue("@val6", CityTextbox.Text);
                            comm.Parameters.AddWithValue("@val7", StateTextbox.Text);
                            comm.Parameters.AddWithValue("@val8", ZIPTextbox.Text);
                            comm.Parameters.AddWithValue("@val9", PhoneTextbox.Text);
                            comm.Parameters.AddWithValue("@val11", HourlywageTextbox.Text);
                            conn.Open();
                            SqlDataReader dr = comm.ExecuteReader();

                            if (dr.HasRows)
                            {
                                MessageBox.Show("Username Already Taken");
                            }
                            else
                            {
                                MessageBox.Show("Employee Updated");
                            }
                            conn.Close();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Employee");
            }
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
            FirstnameTextbox.Clear();
            LastnameTextbox.Clear();
            CityTextbox.Clear();
            StateTextbox.Clear();
            ZIPTextbox.Clear();
            PhoneTextbox.Clear();
            HourlywageTextbox.Clear();
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM EmployeeData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //add employee
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            using (conn = ConnectionClass.getConnection())
            {
                using (SqlCommand comm = new SqlCommand())
                {
                    if (string.IsNullOrWhiteSpace(UsernameTextbox.Text) || string.IsNullOrWhiteSpace(PasswordTextbox.Text) || string.IsNullOrWhiteSpace(FirstnameTextbox.Text) || string.IsNullOrWhiteSpace(LastnameTextbox.Text) || string.IsNullOrWhiteSpace(CityTextbox.Text) || string.IsNullOrWhiteSpace(StateTextbox.Text) || string.IsNullOrWhiteSpace(ZIPTextbox.Text) || string.IsNullOrWhiteSpace(PhoneTextbox.Text) || string.IsNullOrWhiteSpace(HourlywageTextbox.Text))
                    {
                        MessageBox.Show("Invalid Entry");
                        return;
                    }
                    else
                    {
                        comm.Connection = conn;
                        comm.CommandText = "IF NOT EXISTS (Select * FROM EmployeeData WHERE USERNAME=@val2)BEGIN INSERT INTO EmployeeData(Username, Password, FirstName, LastName, City, State, ZIP, Phone, StartDate, HourlyWage) VALUES (@val2, @val3, @val4, @val5, @val6, @val7, @val8, @val9, @val10, @val11) END ELSE BEGIN SELECT 1 END";
                        comm.Parameters.AddWithValue("@val2", UsernameTextbox.Text);
                        comm.Parameters.AddWithValue("@val3", PasswordTextbox.Text);
                        comm.Parameters.AddWithValue("@val4", FirstnameTextbox.Text);
                        comm.Parameters.AddWithValue("@val5", LastnameTextbox.Text);
                        comm.Parameters.AddWithValue("@val6", CityTextbox.Text);
                        comm.Parameters.AddWithValue("@val7", StateTextbox.Text);
                        comm.Parameters.AddWithValue("@val8", ZIPTextbox.Text);
                        comm.Parameters.AddWithValue("@val9", PhoneTextbox.Text);
                        comm.Parameters.AddWithValue("@val10", DateTime.Now.ToString());
                        comm.Parameters.AddWithValue("@val11", HourlywageTextbox.Text);
                        conn.Open();
                        SqlDataReader dr = comm.ExecuteReader();

                        if (dr.HasRows)
                        {
                            MessageBox.Show("Username Already Taken");
                        }
                        else
                        {
                            MessageBox.Show("Employee Added");
                        }
                        conn.Close();
                    }


                }
            }
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM EmployeeData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        //Employee delete
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
                        comm.CommandText = "DELETE FROM EmployeeData WHERE EmployeeID = " + row["EmployeeID"];
                        conn.Open();
                        comm.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Employee Removed");
                    }
                }
            }
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM EmployeeData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataRow row = (dataGridView1.SelectedRows[0].DataBoundItem as DataRowView).Row;
                eid = (int)row["EmployeeID"];
                UsernameTextbox.Text = (string)row["Username"];
                PasswordTextbox.Text = (string)row["Password"];
                FirstnameTextbox.Text = (string)row["FirstName"];
                LastnameTextbox.Text = (string)row["LastName"];
                CityTextbox.Text = (string)row["City"];
                StateTextbox.Text = (string)row["State"];
                ZIPTextbox.Text = (string)row["ZIP"].ToString();
                PhoneTextbox.Text = (string)row["Phone"].ToString();
                HourlywageTextbox.Text = (string)row["HourlyWage"].ToString();
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string username, password, firstname, lastname, wage, city, state, zip, phone;
            username = "%" + UsernameTextbox.Text + "%";
            password = "%" + PasswordTextbox.Text + "%";
            firstname = "%" + FirstnameTextbox.Text + "%";
            lastname = "%" + LastnameTextbox.Text + "%";
            wage = "%" + HourlywageTextbox.Text + "%";
            city = "%" + CityTextbox.Text + "%";
            state = "%" + StateTextbox.Text + "%";
            zip = "%" + ZIPTextbox.Text + "%";
            phone = "%" + PhoneTextbox.Text + "%";
            //populate active orders
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM EmployeeData WHERE EmployeeData.Username LIKE '" + username + "' and EmployeeData.Password LIKE '" + password + "' AND EmployeeData.FirstName LIKE '" + firstname + "' AND EmployeeData.LastName LIKE '" + lastname + "'and EmployeeData.City LIKE '" + city + "' AND EmployeeData.State LIKE '" + state + "' AND EmployeeData.ZIP LIKE '" + zip + "'AND EmployeeData.HourlyWage LIKE '" + wage + "' AND EmployeeData.Phone LIKE '" + phone + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsernameTextbox.Clear();
            PasswordTextbox.Clear();
            FirstnameTextbox.Clear();
            LastnameTextbox.Clear();
            HourlywageTextbox.Clear();
            CityTextbox.Clear();
            StateTextbox.Clear();
            ZIPTextbox.Clear();
            PhoneTextbox.Clear();
            //Populate gridview when page is loaded
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT * FROM EmployeeData", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
