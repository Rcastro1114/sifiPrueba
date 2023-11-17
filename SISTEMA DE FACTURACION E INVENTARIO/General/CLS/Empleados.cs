using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    public class Empleados
    {
        String _idEmpleados;
        String _Nombres;
        String _Apellidos;
        String _DUI;
        String _Telefono;
        String _Correo;
        String _idDirecciones;

        public String idEmpleados { get => _idEmpleados; set => _idEmpleados = value; }
        public string Nombres { get => _Nombres; set => _Nombres = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public string DUI { get => _DUI; set => _DUI = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public String idDirecciones { get => _idDirecciones; set => _idDirecciones = value; }

        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO empleados(Nombres,Apellidos,DUI,Telefono,Correo,idDirecciones) 
                            VALUES('"+_Nombres+"','"+_Apellidos+"','"+_DUI+"','"+_Telefono+"','"+_Correo+"','"+_idDirecciones+"');";
                DataManager.DBOperacion Operacion = new DataManager.DBOperacion();
                FilasInsertadas = Operacion.EjecutarSentencia(Sentencia);
                if(FilasInsertadas > 0)
                {
                    Resultado = true;
                }
            }catch (Exception)
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
                Sentencia = @"UPDATE empleados SET Nombres='" + _Nombres + "',Apellidos='" + _Apellidos + "'," +
                "DUI='" + _DUI + "',Telefono='" + _Telefono + "',Correo='" + _Correo + "',idDirecciones='" + _idDirecciones + "' " +
                "WHERE idEmpleados=" + _idEmpleados + ";";
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
                Sentencia = @"DELETE FROM empleados WHERE idEmpleados=" + _idEmpleados + ";";
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
