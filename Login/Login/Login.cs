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
using CajaFuerteArduinoDAL;

namespace Login
{
    public partial class Login : Form
    {
        List<Personas> datosUser = new List<Personas>();
        private int intentos = 0;
        private Personas persona;
        private PersonasBOL bol;
        private PersonasDAL dal;
        private string fechaActual;
        private string horaActual;
        private string ruta = "Usuarios.xml";
        private string ruta2 = "Intentos.xml";
        private TextBox txtClick;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            persona = new Personas();
            bol = new PersonasBOL();
            dal = new PersonasDAL();
            fechaActual = DateTime.Now.ToString("dd/MM/yyyy");
            horaActual = DateTime.Now.ToString("hh:mm:ss");
            bol.CrearArchivo(ruta2, "IntentosUser");
            txtClick = txtCedula;
        }


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void IngresarVentana()
        {
            try
            {
                string ingreso = "";
                string valor = "";
                bool estado = false;
                persona.Cedula = Convert.ToInt32(txtCedula.Text);
                string cedula = Convert.ToString(persona.Cedula);
                persona.Clave = Convert.ToInt32(txtPassword.Text);

                estado = dal.VerificarEstado(cedula, ruta);

                if (estado.Equals(true))
                {

                    valor = bol.ingresar(persona, ruta);

                    if (intentos <= 2)
                    {
                        intentos += 1;

                        if (valor.Equals("A"))
                        {
                            ingreso = "T";
                            RegistroIntentos(persona, fechaActual, horaActual, ingreso);

                            this.Hide();
                            Admin administrador = new Admin();
                            administrador.Show();
                        }
                        else if (valor.Equals("U"))
                        {
                            ingreso = "T";
                            RegistroIntentos(persona, fechaActual, horaActual, ingreso);

                            MessageBox.Show("Ingreso a el arduino", "", MessageBoxButtons.OK);

                            //Acceso a el arduino 
                        }
                        else if (valor.Equals("N"))
                        {
                            ingreso = "F";
                            bool verificar = dal.VerificarSiEsta(cedula, ruta);

                            if (verificar.Equals(true))
                            {
                                RegistroIntentos(persona, fechaActual, horaActual, ingreso);
                            }

                            MessageBox.Show("Usuario o Contraseña invalida", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        datosUser = bol.CargarTodo(ruta);
                        for (int x = 0; x < datosUser.Count; x++)
                        {
                            persona = datosUser[x];
                            if (persona.Cedula.Equals(Convert.ToInt32(cedula)))
                            {
                                persona = datosUser[x];
                                persona.Estado = "Bloqueado";
                                break;
                            }
                        }

                        dal.modificarPersona(persona, "Usuarios.xml");
                        intentos = 0;

                        MessageBox.Show("Usuario bloqueado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario se encuentra bloqueado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No deben quedar espacios vacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RegistroIntentos(Personas persona, string fecha, string hora, string ingreso)
        {
            dal.RegistrarIntento(persona, fecha, hora, ingreso, ruta2);
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (txtClick != null)
            {
                txtClick.Text += btn.Text;
            }
        }

        private void txtCedula_MouseClick(object sender, MouseEventArgs e)
        {
            txtClick = (TextBox)sender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtClick != null)
            {
                if (!txtClick.Text.Equals(""))
                {
                    txtClick.Text = txtClick.Text.Remove(txtClick.Text.Length - 1);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
    }
}
