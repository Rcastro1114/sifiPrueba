using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI
{
    public partial class VisorVenta : Form
    {

        private void CargarFACTURA()
        {
            DataTable DatosV = new DataTable();
            DataTable DatosDV = new DataTable();

            General.Factura oFactura = new General.Factura();
            DatosV = DataManager.DBConsultas.REPORTEVENTA(PuntoDeVenta._REPVENTA);
            DatosDV = DataManager.DBConsultas.REPORTEDETALLEVENTA(PuntoDeVenta._REPVENTA);

            oFactura.Database.Tables["ventas"].SetDataSource(DatosV);
            oFactura.Database.Tables["detalleventas"].SetDataSource(DatosDV);
            crvVisorVentas.ReportSource = oFactura;
        }

        public VisorVenta()
        {
            InitializeComponent();
        }

        private void VisorVenta_Load(object sender, EventArgs e)
        {
            CargarFACTURA();
        }
    }
}
