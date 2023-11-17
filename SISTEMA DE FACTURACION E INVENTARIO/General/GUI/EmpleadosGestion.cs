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
    public partial class EmpleadosGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        public Empleados _Empleados { get; set; }

        private void CargarEmpleados()
        {
            DataTable oEmpleados = new DataTable();
            try
            {
                oEmpleados = DataManager.DBConsultas.EMPLEADOS();
                dtgvEmpleados.DataSource = oEmpleados;
                lblRegistrosEmpleados.Text = dtgvEmpleados.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch (Exception)
            {

            }
        }
        public EmpleadosGestion()
        {
            InitializeComponent();
        }

        private void EmpleadosGestion_Load(object sender, EventArgs e)
        {
            CargarEmpleados();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            EmpleadosEdicion f = new EmpleadosEdicion();
            f.ShowDialog();
            CargarEmpleados();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                EmpleadosEdicion f = new EmpleadosEdicion();
                f.txt_idEmpleados.Text = dtgvEmpleados.CurrentRow.Cells["idEmpleados"].Value.ToString();
                f.txt_Nombres.Text = dtgvEmpleados.CurrentRow.Cells["Nombres"].Value.ToString();
                f.txt_Apellidos.Text = dtgvEmpleados.CurrentRow.Cells["Apellidos"].Value.ToString();
                f.txt_DUI.Text = dtgvEmpleados.CurrentRow.Cells["DUI"].Value.ToString();
                f.txt_Telefono.Text = dtgvEmpleados.CurrentRow.Cells["Telefono"].Value.ToString();
                f.txt_Correo.Text = dtgvEmpleados.CurrentRow.Cells["Correo"].Value.ToString();
                f.txt_idDirecciones.Text = dtgvEmpleados.CurrentRow.Cells["idDirecciones"].Value.ToString();
                f.ShowDialog();
                CargarEmpleados();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea ELIMINAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CLS.Empleados oEmpleados = new CLS.Empleados();
                oEmpleados.idEmpleados = dtgvEmpleados.CurrentRow.Cells["idEmpleados"].Value.ToString().ToUpper(); ;
               
                if (oEmpleados.Eliminar())
                {
                    MessageBox.Show("¡Registro eliminado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarEmpleados();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue eliminado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }


        private void dtgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iRow = e.RowIndex;
            int iColum = e.ColumnIndex;

            if(iRow >= 0 && iColum > 0)
            {
                _Empleados = new Empleados()
                {
                    idEmpleados = dtgvEmpleados.Rows[iRow].Cells["idEmpleados"].Value.ToString(),
                    Nombres = dtgvEmpleados.Rows[iRow].Cells["Nombres"].Value.ToString(),
                    Apellidos = dtgvEmpleados.Rows[iRow].Cells["Apellidos"].Value.ToString()
                };
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void textBuscar_TextChanged(object sender, EventArgs e)
        {
            if (textBuscar.Text != "")
            {
                dtgvEmpleados.CurrentCell = null;
                foreach (DataGridViewRow r in dtgvEmpleados.Rows)
                {
                    r.Visible = false;
                }
                foreach (DataGridViewRow r in dtgvEmpleados.Rows)
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
                CargarEmpleados();
            }
        }
    }
}
