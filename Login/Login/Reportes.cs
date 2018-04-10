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
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            reporte1();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                MessageBox.Show("hola 2");
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                MessageBox.Show("hola 3");
            }
        }

        public void reporte1()
        {
            MessageBox.Show("hola 1");
        }
    }
}
