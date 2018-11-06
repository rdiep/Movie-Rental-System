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
    public partial class EmployeeMailingList : Form
    {
        public EmployeeMailingList()
        {
            InitializeComponent();
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void EmployeeMailingList_Load(object sender, EventArgs e)
        {
            //Populate gridview when page is loaded
            SqlConnection conn;
            conn = ConnectionClass.getConnection();
            SqlDataAdapter sda;
            sda = new SqlDataAdapter(@"SELECT Firstname, Lastname, Email FROM CustomerData WHERE Email LIKE '%_'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
