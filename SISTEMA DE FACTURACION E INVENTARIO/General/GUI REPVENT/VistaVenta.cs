using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPORTEVENTAS.GUI
{
    public partial class VistaVenta : Form
    {
        private void CargarReporteVentas()
        {
            DataTable DatosV = new DataTable();
            DataTable DatosDV = new DataTable();

            String ultimodetalleventa = null;

            DataTable _Ultimodetalleventa = new DataTable();

            _Ultimodetalleventa = DataManager.DBConsultas.BuscarUltimoDetalleVenta();
            ultimodetalleventa = _Ultimodetalleventa.Rows[0]["idDetalleVentas"].ToString();

            String ultimaventa = null;

            DataTable _ULTIMAVENTA = new DataTable();

            _ULTIMAVENTA = DataManager.DBConsultas.OBTENERULTIMAVENTA();
            ultimaventa = _ULTIMAVENTA.Rows[0]["idVentas"].ToString();

            DatosV = DataManager.DBConsultas.REPORTEVENTA(ultimaventa);
            DatosDV = DataManager.DBConsultas.REPORTEDETALLEVENTA(ultimodetalleventa);

            REPORTEVENTAS.REP.ReporteVentaFactura oREPVENTAS = new REP.ReporteVentaFactura();

            oREPVENTAS.Database.Tables["DatosVenta"].SetDataSource(DatosV);
            oREPVENTAS.Database.Tables["DatosDetalleVentas"].SetDataSource(DatosDV);

            crvVistaVenta.ReportSource = oREPVENTAS;


            /*
        String ultimodetalleventa = null;

        DataTable _Ultimodetalleventa = new DataTable();

        _Ultimodetalleventa = DataManager.DBConsultas.BuscarUltimoDetalleVenta();
        ultimodetalleventa = _Ultimodetalleventa.Rows[0]["idDetalleVentas"].ToString();
        String ultimaventa = null;

        DataTable _ULTIMAVENTA = new DataTable();

        _ULTIMAVENTA = DataManager.DBConsultas.OBTENERULTIMAVENTA();
        ultimaventa = _ULTIMAVENTA.Rows[0]["idVentas"].ToString();



        REPORTEVENTAS.REP.ReporteVentaFactura oREPVENTAS = new REP.ReporteVentaFactura();
        DatosV = DataManager.DBConsultas.REPORTEVENTA(ultimaventa);
        DatosDV = DataManager.DBConsultas.REPORTEDETALLEVENTA(ultimodetalleventa);

        oREPVENTAS.SetDataSource(DatosV);
        oREPVENTAS.SetDataSource(DatosDV);
        crvVistaVenta.ReportSource = oREPVENTAS;*/
        }
        public VistaVenta()
        {
            InitializeComponent();
        }

        private void VistaVenta_Load(object sender, EventArgs e)
        {
            CargarReporteVentas();
        }
    }
}
