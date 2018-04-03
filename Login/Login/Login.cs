using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        private String pin;

        public Login()
        {
            InitializeComponent();
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            try
            {
               pin += ((Button)sender).Text;
                textBox2.Text = pin;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR "+ ex);
            }
        }

    }
}
