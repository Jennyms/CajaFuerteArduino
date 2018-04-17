using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajaFuerteArduinoENL;
using CajaFuerteArduinoBOL;

namespace Login
{
    public partial class Login : Form
    {
        private String pin;
        //private int intentos = 3;
        private Personas persona;
        private PersonasBOL bol;
        private string fechaActual= DateTime.Now.ToString("dd/MM/yyyy");
        private string horaActual =DateTime.Now.ToString("hh:mm:ss");
        private string ruta = "Usuarios.xml";

        public Login()
        {
            InitializeComponent();
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            try
            {
               pin += ((Button)sender).Text;
                txtPassword.Text = pin;

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

        private void IngresarVentana()
        {
            bool valor = false;
            persona.Cedula = Convert.ToInt32(txtCedula.Text);
            persona.Clave = Convert.ToInt32(txtPassword.Text);
            valor = bol.ingresar(persona, ruta);

            if (valor.Equals(true))
            {
                this.Hide();
                Admin administrador = new Admin();
                administrador.Show();
            }
            else
            {
                MessageBox.Show("Ingreso a el arduino", "", MessageBoxButtons.OK);
            }
        }

        private void Ingresar()
        {
            IngresarVentana();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registro = new Register();
            registro.Show();
        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Register registrar = new Register();
            registrar.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            persona = new Personas();
            bol = new PersonasBOL();
        }
    }
}
