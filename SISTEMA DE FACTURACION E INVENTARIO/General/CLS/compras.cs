using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class compras
    {
        String _idCompras;
        String _Fecha;
        String _idProveedores;
        String _idEmpleados;
        float _Total;

        public string IdCompras { get => _idCompras; set => _idCompras = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }
        public string IdProveedores { get => _idProveedores; set => _idProveedores = value; }
        public string IdEmpleados { get => _idEmpleados; set => _idEmpleados = value; }
        public float Total { get => _Total; set => _Total = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO compras(Fecha,idProveedores,idEmpleados,Total) 
                            VALUES(NOW(),'" + _idProveedores + "','" + _idEmpleados + "','" + _Total + "');";
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
