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
        private int intentos = 3;
        private string fechaActual= DateTime.Now.ToString("dd/MM/yyyy");
        private string horaActual =DateTime.Now.ToString("hh:mm:ss");


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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Back)
            {
                this.textBox2.Text = string.Empty;
                String cadena = "123456789";
                int cantidad = 0; 

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
           
        }
    }
}
