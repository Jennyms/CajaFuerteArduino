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
    public partial class Informacion_Users : Form
    {
        public Informacion_Users()
        {
            InitializeComponent();
        }

        private void Informacion_Users_Load(object sender, EventArgs e)
        {
            InfoPersonas();
        }

        public void InfoPersonas()
        {
            ///MessageBox.Show("Hola");
            
        }
    }
}
