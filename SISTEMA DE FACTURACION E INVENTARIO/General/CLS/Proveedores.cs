using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Proveedores
    {
        String _idProveedores;
        String _Proveedor;
        String _Telefono;
        String _Correo;
        String _idDirecciones;


        public string idProveedores { get => _idProveedores; set => _idProveedores = value; }
        public string Proveedor { get => _Proveedor; set => _Proveedor = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string idDirecciones { get => _idDirecciones; set => _idDirecciones = value; }


        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO proveedores(Proveedor,Telefono,Correo,idDirecciones)
                            VALUES('" + _Proveedor + "','" + _Telefono + "','" + _Correo + "','" + _idDirecciones + "');";
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
                Sentencia = @"UPDATE proveedores SET Proveedor='" + _Proveedor +
                 "',Telefono='" + _Telefono + "',Correo='" + _Correo + "',idDirecciones='" + _idDirecciones + "' " +
                "WHERE idProveedores=" + _idProveedores + ";";
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
                Sentencia = @"DELETE FROM proveedores WHERE idProveedores=" + _idProveedores + ";";
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
