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
    public partial class ClientesEdicion : Form
    {
        public ClientesEdicion()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            CLS.Clientes oClientes = new CLS.Clientes();

            oClientes.Nombres = txt_Nombres.Text;
            oClientes.Apellidos = txt_Apellidos.Text;
            oClientes.Telefono = txt_Telefono.Text;
            oClientes.Correo = txt_Correo.Text;
            oClientes.idDirecciones = txt_idDirecciones.Text;
            oClientes.idClientes = txt_idClientes.Text;


            if (txt_idClientes.TextLength > 0)
            {

                if (oClientes.Actualizar())
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

                if (oClientes.Insertar())
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

        private void btn_Direccion_Click_1(object sender, EventArgs e)
        {
            DireccionesGestion f = new DireccionesGestion();
            f.ShowDialog();
        }
    }
}
