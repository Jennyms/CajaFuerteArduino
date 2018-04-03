using CajaFuerteArduinoBOL;
using CajaFuerteArduinoENL;
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
    public partial class Register : Form
    {

        private Personas persona;
        private PersonasBOL bol;
        private string ruta;


        public Register()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login principal = new Login();
            principal.Show();
        }

        private void Guardar()
        {
            try
            {
                persona.Cedula = Convert.ToInt32(txtCedula.Text.Trim());
                persona.Nombre = txtNombre.Text.Trim();
                persona.Clave = Int32.Parse(txtClave.Text.Trim());
                bol.VerificarUsuario(persona, ruta);

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
