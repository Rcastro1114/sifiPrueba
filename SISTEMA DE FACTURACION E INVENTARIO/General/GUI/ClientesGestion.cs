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
    public partial class ClientesGestion : Form
    {

        BindingSource _DATOS = new BindingSource();

        public Clientes _Clientes { get; set; }
        
        private void CargarClientes()
        {
            DataTable oClientes = new DataTable();
            try
            {
                oClientes = DataManager.DBConsultas.CLIENTES();
                dtgvClientes.DataSource = oClientes;
                lblRegistrosClientes.Text = dtgvClientes.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public ClientesGestion()
        {
            InitializeComponent();
        }

        private void ClientesGestion_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ClientesEdicion f = new ClientesEdicion();
            f.ShowDialog();
            CargarClientes();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClientesEdicion f = new ClientesEdicion();
                f.txt_idClientes.Text = dtgvClientes.CurrentRow.Cells["idClientes"].Value.ToString();
                f.txt_Nombres.Text = dtgvClientes.CurrentRow.Cells["Nombres"].Value.ToString();
                f.txt_Apellidos.Text = dtgvClientes.CurrentRow.Cells["Apellidos"].Value.ToString();
                f.txt_Telefono.Text = dtgvClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                f.txt_Correo.Text = dtgvClientes.CurrentRow.Cells["Correo"].Value.ToString();
                f.txt_idDirecciones.Text = dtgvClientes.CurrentRow.Cells["idDirecciones"].Value.ToString();
                f.ShowDialog();
                CargarClientes();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Clientes oClientes = new CLS.Clientes();
                oClientes.idClientes = dtgvClientes.CurrentRow.Cells["idClientes"].Value.ToString().ToUpper(); ;

                if (oClientes.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void dtgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if (iRow >= 0 && iColum > 0)
            {
                _Clientes = new Clientes()
                {
                    idClientes = dtgvClientes.Rows[iRow].Cells["idClientes"].Value.ToString(),
                    Nombres = dtgvClientes.Rows[iRow].Cells["Nombres"].Value.ToString(),
                    Apellidos = dtgvClientes.Rows[iRow].Cells["Apellidos"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                dtgvClientes.CurrentCell = null;
                foreach (DataGridViewRow r in dtgvClientes.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgvClientes.Rows)
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
                CargarClientes();
            }   
        }
    }
}
