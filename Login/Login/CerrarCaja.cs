using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CajaFuerteArduinoDAL;

namespace Login
{

    public partial class CerrarCaja : Form
    {
        private ConexionArduinoDAL cerrar;

        public CerrarCaja()
        {
            InitializeComponent();
        }

        private void CerrarCaja_Load(object sender, EventArgs e)
        {
            cerrar = new ConexionArduinoDAL();
        }

        private void btnCerrarCuenta_Click(object sender, EventArgs e)
        {
            cerrar.enviarOpcion("b");//cerrada
            cerrar.CerrarAbrirServo(90);
            this.Hide();
            Login cerrarCuenta = new Login();
            cerrarCuenta.Show();
        }
    }
}
