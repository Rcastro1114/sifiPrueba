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
    public partial class ProveedoresEdicion : Form
    {
        public ProveedoresEdicion()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            CLS.Proveedores oProveedores = new CLS.Proveedores();

            oProveedores.Proveedor = txt_Proveedor.Text;
            oProveedores.Telefono = txt_Telefono.Text;
            oProveedores.Correo = txt_Correo.Text;
            oProveedores.idDirecciones = txt_idDirecciones.Text;
            oProveedores.idProveedores = txt_idProveedores.Text;


            if (txt_idProveedores.TextLength > 0)
            {

                if (oProveedores.Actualizar())
                {
                    MessageBox.Show("¡Registro actualizado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue actualizado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                if (oProveedores.Insertar())
                {
                    MessageBox.Show("¡Registro insertado correctamente!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("¡El registro no fue insertado!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_Direccion_Click(object sender, EventArgs e)
        {
            DireccionesGestion f = new DireccionesGestion();
            f.ShowDialog();
        }
    }
}
