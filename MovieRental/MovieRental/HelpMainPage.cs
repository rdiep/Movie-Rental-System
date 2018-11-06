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
    public partial class HelpMainPage : Form
    {
        public HelpMainPage()
        {
            InitializeComponent();
        }


        private void BackButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomerMainPage f1 = new CustomerMainPage();
            f1.ShowDialog();
            this.Close();
        }
    }
}
