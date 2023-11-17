using DataManager;
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
    public partial class PuntoDeVenta : Form
    {
        BindingSource _DATOS = new BindingSource();
        SessionManager.Session oSesion = SessionManager.Session.Instancia;

        public static String _REPVENTA = null;
        public static String _REPDETALLEVENTA = null;

        private void CargarFormasDePago()
        {
            DataTable oMunicipios = new DataTable();
            try
            {
                oMunicipios = DataManager.DBConsultas.FORMASDEPAGO();
                cmbo_Formadepago.DataSource = oMunicipios;
                cmbo_Formadepago.DisplayMember = "FormadePago";
                cmbo_Formadepago.ValueMember = "idFormasdePagos";
            }
            catch (Exception)
            {

            }
        }
        public PuntoDeVenta()
        {
            InitializeComponent();
        }

        private void PuntoDeVenta_Load(object sender, EventArgs e)
        {
            txt_Fecha.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_cambio.Text = "0.00";
            txt_Cantidad.Text = "0";
            txt_idClientes.Text = "0";
            txt_idEmpleados.Text = oSesion.IDEmpleados;
            txt_Nombres_emp.Text = oSesion.Nombres;
            txt_apellidos_emp.Text = oSesion.Apellidos;
            txt_idproductos.Text = "0";
            //txt_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

            CargarFormasDePago();
        }

        //BTN QUE BUSCA LOS PRODUCTOS
        private void btn_Buscar_Prod_Click(object sender, EventArgs e)
        {
            using (var formulario = new ProductosGestion())
            {
                var result = formulario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idproductos.Text = formulario._Productos.idProductos.ToString();
                    txt_producto.Text = formulario._Productos.Productos.ToString();
                    txt_precio_pro.Text = formulario._Productos.PrecioUnitario.ToString("0.00");
                    txt_stock.Text = formulario._Productos.Stock.ToString();
                    txt_precio_pro.Select();
                }
                else
                {
                    txt_idproductos.Select();
                }
            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            float precio = 0;
            bool producto_existe = false;

            if(int.Parse(txt_idproductos.Text) == 0)
            {
                MessageBox.Show("Debe seleccionar un PRODUCTO","Mensaje",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(!float.TryParse(txt_precio_pro.Text, out precio))
            {
                MessageBox.Show("Formato de Moneda incorrecto","Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txt_precio_pro.Select();
                return;
            }

            if(Convert.ToInt32(txt_stock.Text) < Convert.ToInt32(txt_Cantidad.Text))
            {
                MessageBox.Show("La Cantidad no puede ser mayor al Stock","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;                
            }

            if (Convert.ToInt32(txt_Cantidad.Text) == 0) {
                MessageBox.Show("La Cantidad no puede ser cero", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach(DataGridViewRow fila in dgtv_ventas.Rows)
            {
                if(fila.Cells["Productos"].Value.ToString() == txt_Nombres_emp.Text)
                {
                    producto_existe = true;
                    break;
                }
            }

            if(!producto_existe)
            {
                dgtv_ventas.Rows.Add(new object[]
                {
                    txt_idproductos.Text,
                    txt_producto.Text,                    
                    txt_Cantidad.Text,
                    precio.ToString("0.00"),                    
                    (int.Parse(txt_Cantidad.Text) * precio).ToString("0.00")
                });
                calculartotal();
                limpiarproducto();
                txt_idproductos.Select();
            }
        }

        private void calculartotal()
        {
            float total = 0;
            if(dgtv_ventas.Rows.Count > 0)
            {
                foreach(DataGridViewRow row in dgtv_ventas.Rows)
                {
                    total += float.Parse(row.Cells["SubTotal"].Value.ToString());
                }
                txt_Total.Text = total.ToString("0.00");
            }
        }

        private void limpiarproducto()
        {           
            txt_producto.Text = "";
            txt_idproductos.Text = "0";
            txt_precio_pro.Text = "";
            txt_stock.Text = "";
            txt_Cantidad.Text = "0";
        }

        

        private void calcularcambio()
        { 
            if(txt_Total.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta","Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            float pagacon;
            float total = float.Parse(txt_Total.Text);

            if(txt_paga.Text.Trim() == "")
            {
                txt_paga.Text = "0";
            }

            if (float.TryParse(txt_paga.Text.Trim(),out  pagacon))
            {
                if (pagacon < total)
                {
                    txt_cambio.Text = "0.00";
                }
                else
                {
                    float cambio = pagacon - total;
                    txt_cambio.Text = cambio.ToString("0.00");
                }
            }
        }

        private void txt_paga_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        //GENERAR VENTA
        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_idEmpleados.Text == "")
            {
                MessageBox.Show("Debe ingresar los DATOS DEL EMPLEADO","Mensaje",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }

            if (txt_idClientes.Text == "")
            {
                MessageBox.Show("Debe ingresar los DATOS DEL CLIENTE", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dgtv_ventas.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar PRODUCTOS a la VENTA", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //CREACIÓN DEL TIPO DE DOCUMENTO TRIBUTARIO ELECTRÓNICO A PROCESAR

            /*DialogResult result = MessageBox.Show("¿Qué tipo de documento tributario desea procesar?","Tipo de documento",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);

            String tipoDTE;
            switch (result) {
                case DialogResult.Yes :
                    tipoDTE = "Factura";
                    //AGREGAR FUNCION
                    facturaConsumidorFinal();
                    break;
                
                case DialogResult.No :
                    tipoDTE = "Credito fiscal";
                    //AGREGAR FUNCION
                    break;
                
                default :
                    tipoDTE = "Cancelar";
                    break;
            }*/


            General.CLS.ventas vent = new General.CLS.ventas();
            vent.idClientes = txt_idClientes.Text.ToString();
            vent.idEmpleados = txt_idEmpleados.Text.ToString();
            vent.idFormasdePago = int.Parse(cmbo_Formadepago.SelectedValue.ToString());
            vent.Total = (float)Convert.ToDouble(txt_Total.Text);

            Boolean b = vent.Insertar();

            if(b == false)
            {
                MessageBox.Show("Fallo al crear la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Factura creada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            String ultimaventa = null;

            DataTable _ULTIMAVENTA = new DataTable();

            try 
            {
                _ULTIMAVENTA = DataManager.DBConsultas.OBTENERULTIMAVENTA();
                ultimaventa = _ULTIMAVENTA.Rows[0]["idVentas"].ToString();

                //PASAR AL REPORTE DE LA VENTA
                _REPVENTA = ultimaventa;
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error en buscar el idVentas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            General.CLS.detalleventas dv = new CLS.detalleventas();
            //String udv = null;

            for (int i = 0; i < dgtv_ventas.Rows.Count; i++)
            {
                dv.idVentas = ultimaventa;
                dv.idProductos = dgtv_ventas.Rows[i].Cells[0].Value.ToString();
                dv.Cantidad = dgtv_ventas.Rows[i].Cells[2].Value.ToString();
                dv.PrecioVenta = (float)Convert.ToDouble(dgtv_ventas.Rows[i].Cells[3].Value.ToString());
                dv.SubTotal = (float)Convert.ToDouble(dgtv_ventas.Rows[i].Cells[4].Value.ToString());

                Boolean pr = dv.Insertar();
            }
            String ultimodetalleventa = null;

            DataTable _ULTIMODETALLEVENTA = new DataTable();
            try
            {
                _ULTIMODETALLEVENTA = DataManager.DBConsultas.OBTENERULTIMODETALLEVENTA();
                ultimodetalleventa = _ULTIMODETALLEVENTA.Rows[0]["idDetalleVentas"].ToString();

                _REPDETALLEVENTA = ultimodetalleventa;
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error en buscar el idDetalleVentas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            VisorVenta f = new VisorVenta();
            f.ShowDialog();

            Close();
        }

        //FUNCION GENERAR FACTURA
        /*private void facturaConsumidorFinal() {
                        
            General.CLS.ventas vent = new General.CLS.ventas();
            vent.idClientes = txt_idClientes.Text.ToString();
            vent.idEmpleados = txt_idEmpleados.Text.ToString();
            vent.idFormasdePago = int.Parse(cmbo_Formadepago.SelectedValue.ToString());
            vent.Total = (float)Convert.ToDouble(txt_Total.Text);

            Boolean b = vent.Insertar();

            if(b == false)
            {
                MessageBox.Show("Fallo al crear la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Factura creada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            String ultimaventa = null;

            DataTable _ULTIMAVENTA = new DataTable();

            try 
            {
                _ULTIMAVENTA = DataManager.DBConsultas.OBTENERULTIMAVENTA();
                ultimaventa = _ULTIMAVENTA.Rows[0]["idVentas"].ToString();

                //PASAR AL REPORTE DE LA VENTA
                _REPVENTA = ultimaventa;
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error en buscar el idVentas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            General.CLS.detalleventas dv = new CLS.detalleventas();
            //String udv = null;

            for (int i = 0; i < dgtv_ventas.Rows.Count; i++)
            {
                dv.idVentas = ultimaventa;
                dv.idProductos = dgtv_ventas.Rows[i].Cells[0].Value.ToString();
                dv.Cantidad = dgtv_ventas.Rows[i].Cells[2].Value.ToString();
                dv.PrecioVenta = (float)Convert.ToDouble(dgtv_ventas.Rows[i].Cells[3].Value.ToString());
                dv.SubTotal = (float)Convert.ToDouble(dgtv_ventas.Rows[i].Cells[4].Value.ToString());

                Boolean pr = dv.Insertar();
            }
            String ultimodetalleventa = null;

            DataTable _ULTIMODETALLEVENTA = new DataTable();
            try
            {
                _ULTIMODETALLEVENTA = DataManager.DBConsultas.OBTENERULTIMODETALLEVENTA();
                ultimodetalleventa = _ULTIMODETALLEVENTA.Rows[0]["idDetalleVentas"].ToString();

                _REPDETALLEVENTA = ultimodetalleventa;
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error en buscar el idDetalleVentas", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            VisorVenta f = new VisorVenta();
            f.ShowDialog();

            Close();
        }*/

        private void dgtv_ventas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.eliminar15.Width;
                var h = Properties.Resources.eliminar15.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - w) / 2;

                e.Graphics.DrawImage(Properties.Resources.eliminar15, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgtv_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgtv_ventas.Columns[e.ColumnIndex].Name == "eliminar")
            {
                int index = e.RowIndex;
                if (index >= 0)
                {
                    dgtv_ventas.Rows.RemoveAt(index);
                    calculartotal();
                }
            }
        }

        private void btn_buscar_cli_Click(object sender, EventArgs e)
        {
            using (var formulario = new ClientesGestion())
            {
                var result = formulario.ShowDialog();

                if (result == DialogResult.OK)
                {
                    txt_idClientes.Text = formulario._Clientes.idClientes.ToString();
                    txt_Nombres_cli.Text = formulario._Clientes.Nombres.ToString();
                    txt_Apellidos_cli.Text = formulario._Clientes.Apellidos.ToString();
                }
                else
                {
                    txt_idClientes.Select();
                }
            }
        }
    }
}
