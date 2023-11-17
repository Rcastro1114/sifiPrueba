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
    public partial class ProductosEdicion : Form
    {
        public ProductosEdicion()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            CLS.Product oProductos = new CLS.Product();

            oProductos.Productos = txt_Productos.Text;
            oProductos.PrecioUnitario = (float)Convert.ToDouble(txt_PrecioUnitario.Text);
            oProductos.Marca = txt_Marca.Text;
            oProductos.idProductos = txt_idProductos.Text;
            oProductos.Stock = txt_Stock.Text;
            
            if (txt_idProductos.TextLength > 0)
            {
                
                if (oProductos.Actualizar())
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
                //Realizar la operacion de insertar
                if (oProductos.Insertar())
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
    }
}
