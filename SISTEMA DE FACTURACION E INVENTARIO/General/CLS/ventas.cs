using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class ventas
    {
        String _idVentas;
        String _idClientes;
        String _idEmpleados;
        int    _idFormasdePago;
        String _Fecha;
        float  _Total;
        

        public string idVentas { get => _idVentas; set => _idVentas = value; }
        public string idClientes { get => _idClientes; set => _idClientes = value; }
        public int idFormasdePago { get => _idFormasdePago; set => _idFormasdePago = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public float Total { get => _Total; set => _Total = value; }
        public string idEmpleados { get => _idEmpleados; set => _idEmpleados = value; }
        

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO ventas(idClientes,idEmpleados,idFormasdePago,Fecha,Total) 
                            VALUES('" + _idClientes + "','" + _idEmpleados + "','" + _idFormasdePago + "',NOW(),'" + _Total + "');";
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

                Sentencia = @"update ventas set idClientes = '" + _idClientes + "', idEmpleados = '"+_idEmpleados+"', idFormasdePago  = '" + _idFormasdePago + "' where idVentas = " + _idVentas + ";";
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
            Int32 FilasInsertadas = 0;

            try
            {

                Sentencia = @"delete from ventas where idVentas = '" + _idVentas + "';";
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
