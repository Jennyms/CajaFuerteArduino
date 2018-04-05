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
    public partial class DatosUsuarios : Form
    {

        private Personas persona;
        private PersonasBOL bol; 
        private string ruta;


        public DatosUsuarios()
        {
            InitializeComponent();
            CenterToScreen();

        }

        private void CargarTabla()
        {
            dataGridView1.DataSource = bol.CargarTodo(ruta);
            dataGridView1.Columns[0].Width = 125;
            dataGridView1.Columns[1].Width = 125;
            dataGridView1.Columns[2].Width = 125;
            dataGridView1.Columns[3].Width = 125;
        }

        private void DatosUsuarios_Load(object sender, EventArgs e)
        {
            persona = new Personas();
            bol = new PersonasBOL();
            ruta = "Usuarios.xml";
            
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
    }
}
