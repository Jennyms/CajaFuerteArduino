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
        private string fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
        ///pin = pin.Remove(pin.Length - 1);
        public Register()
        {
            InitializeComponent();
            CenterToScreen();
            
        }

        private void Register_Load(object sender, EventArgs e)
        {
            ruta = "Usuarios.xml";
            bol = new  PersonasBOL();
            persona = new Personas();
            bol.CrearArchivo(ruta, "usuario");
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Login principal = new Login();
            //principal.Show();
            this.Dispose();
        }

        public void Guardar()
        {
            string tipo = "";
            try
            {
                if (BoxAdministrador.Checked)
                {
                    tipo = "T";
                }
                else
                {
                    tipo = "U";
                }
                persona.Cedula = Convert.ToInt32(txtCedula.Text.Trim());
                persona.Nombre = txtNombre.Text.Trim();
                persona.Clave = Int32.Parse(txtClave.Text.Trim());
                persona.Fecha = fechaActual;
                persona.Estado = "Activo";//Bloqueado
                persona.Tipo = tipo;
                ruta = "Usuarios.xml";
                bol.VerificarUsuario(persona, ruta);

                txtCedula.Text = "";
                txtClave.Text = "";
                txtNombre.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
