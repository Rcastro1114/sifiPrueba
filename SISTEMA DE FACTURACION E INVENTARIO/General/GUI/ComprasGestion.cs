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
    public partial class ComprasGestion : Form
    {
        public ComprasGestion()
        {
            InitializeComponent();
        }

        private void btn_proveedor_Click(object sender, EventArgs e)
        {
            using (var formulario = new ProveedoresGestion())
            {
                var result = formulario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idproveedores.Text = formulario._Proveedores.idProveedores.ToString();
                    
                }
                else
                {
                    txt_idproveedores.Select();
                }
            }
        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            using (var formulario = new EmpleadosGestion())
            {
                var result = formulario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idempleados.Text = formulario._Empleados.idEmpleados.ToString();
                  
                }
                else
                {
                    txt_idempleados.Select();
                }
            }
        }

        private void btn_Agregar_Prod_Click(object sender, EventArgs e)
        {
            GUI.ProductosGestion f = new GUI.ProductosGestion();
            f.ShowDialog();
            dgv_compra.DataSource = null;
            dgv_compra.Rows.Add
                (
                    //GUI.ProductosGestion._idProductos,
                    txt_Cantidad.Text,
                    txt_precioCompra.Text   
                );
            calculartotal();
        }

        private void calculartotal()
        {
            int cant = int.Parse(txt_Cantidad.Text.ToString());
            float preCom = (float)Convert.ToDouble(txt_precioCompra.Text.ToString());
            float totalCom = 0;

            if (dgv_compra.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgv_compra.Rows) { 

                    cant = int.Parse(row.Cells["Cantidad"].Value.ToString());
                    preCom = float.Parse(row.Cells["PrecioCompra"].Value.ToString());

                    totalCom += (preCom * cant);
                }
                txt_TotalCompra.Text = totalCom.ToString("0.00");
            }



        }

        private void ComprasGestion_Load(object sender, EventArgs e)
        {

        }


        private void btn_guardar_Click(object sender, EventArgs e)
        {
            
            CLS.compras c = new CLS.compras();
            c.IdProveedores = txt_idproveedores.Text.ToString();
            c.IdEmpleados = txt_idempleados.Text.ToString();
            c.Total = (float) Convert.ToDouble(txt_TotalCompra.Text.ToString());

            Boolean f = c.Insertar();
            if(f == false)
            {
                MessageBox.Show("Erro al crear la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Éxito al crear la compra", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            String ultimacompra = null;
            DataTable _UltimaCompra = new DataTable();

            try 
            {
                _UltimaCompra = DataManager.DBConsultas.OBTENERULRIMACOMPRA();
                ultimacompra = _UltimaCompra.Rows[0]["idCompras"].ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el id de la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            CLS.detallecompras dc = new CLS.detallecompras();
            for (int i = 0; i < dgv_compra.Rows.Count;i++) 
            {
                dc.IdProductos = dgv_compra.Rows[i].Cells[0].Value.ToString();
                dc.Cantidad = dgv_compra.Rows[i].Cells[1].Value.ToString();
                dc.IdCompras = ultimacompra;
                dc.PrecioCompra = (float)Convert.ToDouble(dgv_compra.Rows[i].Cells[2].Value.ToString());
                Boolean ic = dc.Insertar();
            }
            Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_eliminar_prod_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = dgv_compra.SelectedRows[0];
            dgv_compra.Rows.Remove(fila);
            dgv_compra.Refresh();
        }
    }
}
