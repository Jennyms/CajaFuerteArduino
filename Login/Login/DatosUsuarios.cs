using CajaFuerteArduinoBOL;
using CajaFuerteArduinoENL;
using CajaFuerteArduinoDAL;
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
    public partial class DatosUsuarios : Form
    {

        private Personas persona;
        private PersonasBOL bol;
        private PersonasDAL datos;
        private string ruta = "Usuarios.xml";


        public DatosUsuarios()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void CargarTabla()
        {
            dataGridView1.DataSource = bol.CargarTodo(ruta);
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Visible = false;
        }

        private void DatosUsuarios_Load(object sender, EventArgs e)
        {
            persona = new Personas();
            bol = new PersonasBOL();
            datos = new PersonasDAL();
            //ruta = "Usuarios.xml";
            
            bol.CrearArchivo(ruta, "Usuarios");
            CargarTabla();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtFiltro.Text != "")
            {
                dataGridView1.CurrentCell = null;
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(txtFiltro.Text.ToUpper())==0)
                        {
                            r.Visible = true;
                            break;

                        }
                    }
                }
            }
            else
            {
                CargarTabla();
            }
        }

        public void desbloquear_User()
        {
            Int32 numero = dataGridView1.GetCellCount(DataGridViewElementStates.Selected);
            if (numero == 6)
            {
                string cedula = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);
                string estado = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value);
                string tipo = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);
                if (tipo.Equals("T"))//verifica si es administrador
                {
                    txtMensaje.Width = 430;
                    txtMensaje.Height = 39;
                    txtMensaje.Text = "Error no se puede ejecutar acción con el Administrador.";
                    txtMensaje.Visible = true;
                    temporizador();
                }
                else
                {
                    if (estado.Equals("Bloqueado"))
                    {
                        persona.Cedula = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                        persona.Nombre = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value);
                        persona.Fecha = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value);
                        persona.Clave = Convert.ToInt32(dataGridView1.CurrentRow.Cells[3].Value);
                        persona.Estado = "Activo";
                        persona.Tipo = Convert.ToString(dataGridView1.CurrentRow.Cells[5].Value);

                        CargarTabla();
                        txtMensaje2.Width = 220;
                        txtMensaje2.Height = 39;
                        txtMensaje2.Text = Convert.ToString(datos.modificarPersona(persona, "Usuarios.xml").Text);
                        txtMensaje2.Visible = true;
                        temporizador();
                    }
                    else
                    {
                        txtMensaje.Width = 390;
                        txtMensaje.Height = 39;  ///591, 39
                        txtMensaje.Text = "Error no se puede debloquear un Usuario Activo.";
                        txtMensaje.Visible = true;
                        temporizador();
                    }
                }
            }
        }

        private void temporizador()
        {
            tiempoMensaje.Start();
            tiempoMensaje.Interval = 2500;
            tiempoMensaje.Tick += (s, a) => 
            {
                ((Timer)s).Stop();
                txtMensaje.Text = "";
                txtMensaje.Visible = false;
                txtMensaje2.Text = "";
                txtMensaje2.Visible = false;
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            desbloquear_User();
        }
    }
}
