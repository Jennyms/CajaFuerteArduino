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
        //private int intentos = 3;
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

            //if (e.KeyChar == (char)Keys.Back)
            //{
            //    this.textBox2.Text = string.Empty;
            //    String cadena = "123456789";
            //    int cantidad = 0; 

            //}
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registro = new Register();
            registro.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {

        }
    }
}
