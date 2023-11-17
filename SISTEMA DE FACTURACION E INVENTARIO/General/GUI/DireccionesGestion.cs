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
    public partial class DireccionesGestion : Form
    {
        BindingSource _DATOS = new BindingSource();

        private void CargarMunicipios()
        {
            DataTable oMunicipios = new DataTable();
            try
            {
                oMunicipios = DataManager.DBConsultas.MUNICIPIOS();
                cbboMunicipios.DataSource = oMunicipios;
                cbboMunicipios.DisplayMember = "municipios";
                cbboMunicipios.ValueMember = "idMunicipios";
            }
            catch (Exception)
            {

            }
        }

        private void CargarDirecciones()
        {
            DataTable oDirecciones = new DataTable();
            String pIDMunicipios = cbboMunicipios.SelectedValue.ToString();
            try
            {
                oDirecciones = DataManager.DBConsultas.MOSTRAR_DIRECCIONES();
                dtgvDirecciones.DataSource = oDirecciones;
                lblRegistrosClt.Text = dtgvDirecciones.Rows.Count.ToString() + " Registros Encontrados";
            }
            catch(Exception)
            {

            }
        }

        public DireccionesGestion()
        {
            InitializeComponent();
        }

        private void DireccionesGestion_Load(object sender, EventArgs e)
        {
            CargarMunicipios();
            CargarDirecciones();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            CLS.Direcciones oDirecciones = new CLS.Direcciones();
            oDirecciones.Residencia = txt_Residencia.Text;
            oDirecciones.Canton = txt_Canton.Text;
            oDirecciones.Cacerio = txt_Cacerio.Text;
            oDirecciones.IdMunicipios = int.Parse(cbboMunicipios.SelectedValue.ToString());
            oDirecciones.IdDirecciones = txt_idDirecciones.Text;

            if (txt_idDirecciones.TextLength > 0)
            {
                if (oDirecciones.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDirecciones();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (oDirecciones.Insertar())
                {
                    MessageBox.Show("¡Registro agregado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarDirecciones();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue agregado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Realmente desea EDITAR el registro seleccionado?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DireccionesGestion f = new DireccionesGestion();
                f.txt_idDirecciones.Text = dtgvDirecciones.CurrentRow.Cells["idDirecciones"].Value.ToString();
                f.txt_Residencia.Text = dtgvDirecciones.CurrentRow.Cells["Residencia"].Value.ToString();
                f.ShowDialog();
                CargarDirecciones();               
            }
        }
    }
}
