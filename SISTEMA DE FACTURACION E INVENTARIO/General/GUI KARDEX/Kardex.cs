using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace General.GUI_KARDEX
{
    public partial class Kardex : Form
    {
        BindingSource _DATOS = new BindingSource();
        DataTable oKardexProductos = new DataTable();

        private void CargarBusquedaPorNombre() {
            try
            {
                //BUSCAR EL PRODUCTO POR NOMBRE
                _DATOS.DataSource = DataManager.DBConsultas.BUSCARPRDUCTOPORNOMBREKARDEX(txt_nombreP.Text.ToString());
                dgt_kardex.AutoGenerateColumns = false;
                dgt_kardex.DataSource = _DATOS;
            }
            catch (Exception ex) {
                MessageBox.Show("No se han encontrado los datos" + ex.Message);
            }
        }

        private void CargarBusqueda()
        {
            try 
            {
                //BUSCAR EL PRODUCTO POR ID
                _DATOS.DataSource = DataManager.DBConsultas.BUSCARPRDUCTOKARDEX(txt_idProducto.Text.ToString());
                dgt_kardex.AutoGenerateColumns = false;
                dgt_kardex.DataSource = _DATOS;
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se han encontrado los datos"+ ex.Message);
            }
        }

        private void CargarKardex()
        {
            try
            {
                oKardexProductos = DataManager.DBConsultas.KARDEXPRODUCTOS();
                dgt_kardex.DataSource = oKardexProductos;
                lblKardex.Text = dgt_kardex.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public Kardex()
        {
            InitializeComponent();
        }

        private void Kardex_Load(object sender, EventArgs e)
        {
            CargarKardex();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if(txt_idProducto.Text.Length > 0)
            {
                CargarBusqueda();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_idProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                if (txt_idProducto.Text.Length > 0)
                {
                    CargarBusqueda();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_buscar_p_Click(object sender, EventArgs e)
        {
            if (txt_idProducto.Text.Length > 0)
            {
                CargarBusquedaPorNombre();
            }
            else
            {
                MessageBox.Show("No se ha encontrado el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_nombreP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (!string.IsNullOrWhiteSpace(txt_nombreP.Text))
                {
                    CargarBusquedaPorNombre();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado el producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_cargar_Click(object sender, EventArgs e)
        {
            CargarKardex();
        }
    }
}
