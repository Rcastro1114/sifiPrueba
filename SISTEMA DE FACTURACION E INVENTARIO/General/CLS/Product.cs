using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Product
    {
        String _idProductos;
        String _Productos;
        float _PrecioUnitario;
        String _Marca;
        String _Stock;

        public string idProductos { get => _idProductos; set => _idProductos = value; }
        public string Productos { get => _Productos; set => _Productos = value; }
        public float PrecioUnitario { get => _PrecioUnitario; set => _PrecioUnitario = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Stock { get => _Stock; set => _Stock = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO productos(Productos,PrecioUnitario,Marca,Stock)
                            VALUES('" + _Productos + "','" + _PrecioUnitario + "','" + _Marca + "','"+_Stock+"');";
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

        public Boolean Actualizar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"UPDATE productos SET Productos='" + _Productos + "',PrecioUnitario='" + _PrecioUnitario + "',Stock='"+ _Stock +"' " +
                "WHERE idProductos=" + _idProductos + ";";
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


        public Boolean Eliminar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasEliminadas = 0;
            try
            {
                Sentencia = @"DELETE FROM productos WHERE idProductos=" + _idProductos + ";";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasEliminadas = Operacion.EjecutarSentencia(Sentencia);
                if (FilasEliminadas > 0)
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
