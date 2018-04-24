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
    public partial class Admin : Form
    {
        private ConexionArduinoDAL arduino;

        public Admin()
        {
            InitializeComponent();
            
            //arduino.enviarOpcion("b");//cerrada
            //arduino.CerrarAbrirServo(90);
        }

        private void InfoCarros(object formHija)
        {
            if (this.Informacion_Users.Controls.Count > 0)
                this.Informacion_Users.Controls.RemoveAt(0); //lo que hace es verificar que el panel tenga info si la tiene entonces la borra para poder mostrar la otra

            Form fr = formHija as Form;
            fr.TopLevel = false; // lo que hace es decir que no es un formulario de nivel superior sino que le dice que es secundario
            fr.Dock = DockStyle.Fill; // lo que hace esque el form se acople a el panel donde se va a mostrar
            this.Informacion_Users.Controls.Add(fr);
            this.Informacion_Users.Tag = fr;
            fr.Show();

        }

        private void btnInfo_users_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Height = btnInfo_users.Height;
            panel2.Top = btnInfo_users.Top;
        }

        private void btnInfo_users_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnReportes_MouseHover(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Height = btnReportes.Height;
            panel2.Top = btnReportes.Top;
        }

        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        private void btnInfo_users_Click(object sender, EventArgs e)
        {
            InfoCarros(new DatosUsuarios());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            InfoCarros(new Reportes());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //arduino = new ConexionArduinoDAL();
            //arduino.cerrarPuerto();
            //this.Hide();
            //Login regresar = new Login();
            //regresar.Show();
        }
    }
}
