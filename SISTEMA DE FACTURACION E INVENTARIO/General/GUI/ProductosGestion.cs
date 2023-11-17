using General.CLS;
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
    public partial class ProductosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        public Product _Productos { get; set; }

        private void CargarDatos()
        {
            try
            {
                _DATOS.DataSource = DataManager.DBConsultas.PRODUCTOS();
                dtgvProductos.AutoGenerateColumns = false;
                dtgvProductos.DataSource = _DATOS;
                lblRegistrosProd.Text = dtgvProductos.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }

        public ProductosGestion()
        {
            InitializeComponent();
        }

        private void ProductosGestion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductosEdicion f = new ProductosEdicion();
                f.txt_idProductos.Text = dtgvProductos.CurrentRow.Cells["idProductos"].Value.ToString();
                f.txt_Productos.Text = dtgvProductos.CurrentRow.Cells["Productos"].Value.ToString();
                f.txt_PrecioUnitario.Text = dtgvProductos.CurrentRow.Cells["PrecioUnitario"].Value.ToString();
                f.txt_Marca.Text = dtgvProductos.CurrentRow.Cells["Marca"].Value.ToString();
                f.txt_Stock.Text = dtgvProductos.CurrentRow.Cells["Stock"].Value.ToString();
                f.ShowDialog();
                CargarDatos();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Product oProductos = new CLS.Product();
                oProductos.idProductos = dtgvProductos.CurrentRow.Cells["idProductos"].Value.ToString().ToUpper(); ;
                //Realizar la operacion de Eliminar
                if (oProductos.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDatos();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ProductosEdicion f = new ProductosEdicion();
            f.ShowDialog();
            CargarDatos();
        }

        private void dtgvProductos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum >= 0)
            {
                _Productos = new Product()
                {
                    idProductos = dtgvProductos.Rows[iRow].Cells["idProductos"].Value.ToString(),
                    Productos = dtgvProductos.Rows[iRow].Cells["Productos"].Value.ToString(),
                    PrecioUnitario = (float)Convert.ToDecimal(dtgvProductos.Rows[iRow].Cells["PrecioUnitario"].Value.ToString()),
                    Stock = dtgvProductos.Rows[iRow].Cells["Stock"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                dtgvProductos.CurrentCell = null;
                foreach (DataGridViewRow r in dtgvProductos.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgvProductos.Rows)
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
    }
}
