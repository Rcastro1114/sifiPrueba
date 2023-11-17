using DataManager;
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
    public partial class BuscarProductos : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarFormasDePago()
        {
            DataTable oMunicipios = new DataTable();
            try
            {
                oMunicipios = DataManager.DBConsultas.FORMASDEPAGO();
                cmbo_Formadepago.DataSource = oMunicipios;
                cmbo_Formadepago.DisplayMember = "FormadePago";
                cmbo_Formadepago.ValueMember = "idFormasdePagos";
            }
            catch (Exception)
            {

            }
        }
        public BuscarProductos()
        {
            InitializeComponent();
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            txt_Fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CargarFormasDePago();
            generarNoFactura();
        }

        private void generarNoFactura()
        {
            
        }
    }
}
