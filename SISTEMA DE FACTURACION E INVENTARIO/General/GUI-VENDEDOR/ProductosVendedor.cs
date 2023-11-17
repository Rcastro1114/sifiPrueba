using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI_VENDEDOR
{
    public partial class ProductosVendedor : Form
    {
        BindingSource _DATOS = new BindingSource();
        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PRODUCTOS();
                dtgv_Productos_Vendedor.AutoGenerateColumns = false;
                dtgv_Productos_Vendedor.DataSource = _DATOS;
                //lblRegistrosProd.Text = dtgvProductos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public ProductosVendedor()
        {
            InitializeComponent();
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                dtgv_Productos_Vendedor.CurrentCell = null;
                foreach (DataGridViewRow r in dtgv_Productos_Vendedor.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgv_Productos_Vendedor.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(textBuscar.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
                }
            }
            else
            {
                CargarDatos();
            }
        }

        private void ProductosVendedor_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }
    }
}
