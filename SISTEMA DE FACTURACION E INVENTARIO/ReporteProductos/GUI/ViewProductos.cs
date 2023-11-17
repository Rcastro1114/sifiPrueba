using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReporteProductos.GUI
{
    public partial class ViewProductos : Form
    {
        private void CargarReporteProductos()
        {
            DataTable DATOS = new DataTable();
            ReporteProductos.REP.RepProductos oReportesProd = new REP.RepProductos();
            DATOS = DataManager.DBConsultas.PRODUCTOS();
            oReportesProd.SetDataSource(DATOS);
            crvVisorPoruductos.ReportSource = oReportesProd;
        }
        public ViewProductos()
        {
            InitializeComponent();
        }

        private void ViewProductos_Load(object sender, EventArgs e)
        {
            CargarReporteProductos();
        }
    }
}
