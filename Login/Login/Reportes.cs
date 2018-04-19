using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using CajaFuerteArduinoDAL;

namespace Login
{
    public partial class Reportes : Form
    {
        private PersonasDAL dal;

        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            dal = new PersonasDAL();
            reporte1();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 2)
            {
                MessageBox.Show("hola 3");
                reporte3();
            }
        }

        public void reporte1()
        {
            List<object> estadoUser = new List<object>();
            List<object> estadoUser2 = new List<object>();
            List<object> resultado = new List<object>();

            //MessageBox.Show("hola 1");

            estadoUser.Clear();

            int contador1 = 0;

            this.Grafico_1.Series.Clear();

            this.Grafico_1.Titles.Clear();
            this.Grafico_1.Titles.Add("Cantidad de Usuarios Activos y Bloqueados");

            Series series = this.Grafico_1.Series.Add("Cantidad de Usuarios Activos y Bloqueados");
            series.ChartType = SeriesChartType.Pie;  /// cambia la forma del grafico

            estadoUser = dal.Reporte1();//tiene la cantidad de los usuarios activos y bloqueados 
            estadoUser2 = estadoUser;

            for (int x = 0; x < estadoUser.Count;)
            {
                contador1 = 0;
                for (int y = 0; y < estadoUser2.Count; y++)
                {
                    if (estadoUser[x].Equals(estadoUser2[y]))
                    {
                        contador1 += 1;
                    }
                }

                resultado.Add(estadoUser[x]);
                resultado.Add(contador1);
                contador1 = 0;

                string nombre = Convert.ToString(estadoUser[x]);

                foreach (string c in estadoUser.ToList())//este foreach recorre la lista para eliminar el hotel que ya se conto
                {
                    if (c.Equals(nombre))
                    {
                        estadoUser.Remove(nombre);
                    }
                }
                x = 0;
            }
            for (int t = 0; t < resultado.Count; t++)
            {
                series.Points.AddXY(resultado[t], resultado[t + 1]);
                t += 1;
            }
            Grafico_1.Series["Cantidad de Usuarios Activos y Bloqueados"].IsValueShownAsLabel = true;
        }

        public void reporte2()
        {
            string date1 = Fecha1.Value.Date.ToString("dd/MM/yyyy");
            string date2 = Fecha2.Value.Date.ToString("dd/MM/yyyy");
            List<object> ingresoFecha = new List<object>();
            List<object> ingresoFecha2 = new List<object>();
            List<object> resultado = new List<object>();
            int contador1 = 0;

            this.Grafico_2.Series.Clear();

            this.Grafico_2.Titles.Clear();
            this.Grafico_2.Titles.Add("Cantidad de Usuarios que ingresan por Fecha.");

            Series series = this.Grafico_2.Series.Add("Cantidad de Usuarios que ingresan por Fecha.");
            series.ChartType = SeriesChartType.Pie;  /// cambia la forma del grafico

            ingresoFecha = dal.Reporte2(date1, date2);//tiene la cantidad de los usuarios activos y bloqueados 
            ingresoFecha2 = ingresoFecha;

            for (int x = 0; x < ingresoFecha.Count;)
            {
                contador1 = 0;
                for (int y = 0; y < ingresoFecha2.Count; y++)
                {
                    if (ingresoFecha[x].Equals(ingresoFecha2[y]))
                    {
                        contador1 += 1;
                    }
                }

                resultado.Add(ingresoFecha[x]);
                resultado.Add(contador1);
                contador1 = 0;

                string nombre = Convert.ToString(ingresoFecha[x]);

                foreach (string c in ingresoFecha.ToList())//este foreach recorre la lista para eliminar el hotel que ya se conto
                {
                    if (c.Equals(nombre))
                    {
                        ingresoFecha.Remove(nombre);
                    }
                }
                x = 0;
            }
            for (int t = 0; t < resultado.Count; t++)
            {
                if (resultado[t].Equals("T"))
                {
                    series.Points.AddXY("Acceso Correcto", resultado[t + 1]);
                    t += 1;
                }
                else if (resultado[t].Equals("F"))
                {
                    series.Points.AddXY("Acceso Incorrecto", resultado[t + 1]);
                    t += 1;
                }
            }
            Grafico_2.Series["Cantidad de Usuarios que ingresan por Fecha."].IsValueShownAsLabel = true;
        }

        public void reporte3()
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            reporte2();
        }
    }
}
