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
    public partial class EmpleadosEdicion : Form
    {
        

        public EmpleadosEdicion()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            
            CLS.Empleados oEmpleados = new CLS.Empleados();
            
            oEmpleados.Nombres = txt_Nombres.Text;
            oEmpleados.Apellidos = txt_Apellidos.Text;
            oEmpleados.DUI = txt_DUI.Text;
            oEmpleados.Telefono = txt_Telefono.Text;
            oEmpleados.Correo = txt_Correo.Text;
            oEmpleados.idDirecciones = txt_idDirecciones.Text;
            oEmpleados.idEmpleados = txt_idEmpleados.Text;


            if (txt_idEmpleados.TextLength > 0)
            {
                
                if (oEmpleados.Actualizar())
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
                
                if (oEmpleados.Insertar())
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

        private void EmpleadosEdicion_Load(object sender, EventArgs e)
        {

        }
    }
}
