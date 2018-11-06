using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieRental
{
    public partial class CustomerRateMovie : Form
    {
        public static int? rating = null;
        public CustomerRateMovie()
        {
            InitializeComponent();
        }

        private void CustomerRateMovie_Load(object sender, EventArgs e)
        {
            Movie.Text = CustomerMainPage.movietitle;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please Rate Movie");
            }
            else
            {
                rating = int.Parse(comboBox1.SelectedItem.ToString());
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
