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
    public partial class ProveedoresGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        public Proveedores _Proveedores { get; set; }

        private void CargarProveedores()
        {
            DataTable oProveedores = new DataTable();
            try
            {
                oProveedores = DataManager.DBConsultas.PROVEEDORES();
                dtgvProveedores.DataSource = oProveedores;
                lblRegistrosProveedores.Text = dtgvProveedores.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }


        public ProveedoresGestion()
        {
            InitializeComponent();
        }

        private void ProveedoresGestion_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ProveedoresEdicion f = new ProveedoresEdicion();
            f.ShowDialog();
            CargarProveedores();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProveedoresEdicion f = new ProveedoresEdicion();
                f.txt_idProveedores.Text = dtgvProveedores.CurrentRow.Cells["idProveedores"].Value.ToString();
                f.txt_Proveedor.Text = dtgvProveedores.CurrentRow.Cells["Proveedor"].Value.ToString();
                f.txt_Telefono.Text = dtgvProveedores.CurrentRow.Cells["Telefono"].Value.ToString();
                f.txt_Correo.Text = dtgvProveedores.CurrentRow.Cells["Correo"].Value.ToString();
                f.txt_idDirecciones.Text = dtgvProveedores.CurrentRow.Cells["idDirecciones"].Value.ToString();
                f.ShowDialog();
                CargarProveedores();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Proveedores oProveedores = new CLS.Proveedores();
                oProveedores.idProveedores = dtgvProveedores.CurrentRow.Cells["idProveedores"].Value.ToString().ToUpper(); ;

                if (oProveedores.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProveedores();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dtgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Proveedores = new Proveedores()
                {
                    idProveedores = dtgvProveedores.Rows[iRow].Cells["idProveedores"].Value.ToString(),
                    Proveedor = dtgvProveedores.Rows[iRow].Cells["Proveedor"].Value.ToString(),
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                dtgvProveedores.CurrentCell = null;
                foreach (DataGridViewRow r in dtgvProveedores.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgvProveedores.Rows)
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
                CargarProveedores();
            }
        }
    }
}
