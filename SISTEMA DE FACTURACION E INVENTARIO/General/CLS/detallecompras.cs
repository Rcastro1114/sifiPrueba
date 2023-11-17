using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class detallecompras
    {
        String _idDetalleCompras;
        String _idProductos;
        String _Cantidad;
        String _idCompras;
        float _PrecioCompra;

        public string IdDetalleCompras { get => _idDetalleCompras; set => _idDetalleCompras = value; }
        public string IdProductos { get => _idProductos; set => _idProductos = value; }
        public string Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public string IdCompras { get => _idCompras; set => _idCompras = value; }
        public float PrecioCompra { get => _PrecioCompra; set => _PrecioCompra = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO detallecompras(idProductos,Cantidad,idCompras,PrecioCompra) 
                            VALUES('" + _idProductos + "','" + _Cantidad + "','" + _idCompras + "','" + _PrecioCompra + "');";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }
            catch (Exception)
            {
                Resultado = false;
            }
            return Resultado;
        }
    }
}
