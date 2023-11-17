using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.CLS
{
    class Direcciones
    {
        String _idDirecciones;
        String _Residencia;
        String _Canton;
        String _Cacerio;
        int _idMunicipios;

        public String IdDirecciones { get => _idDirecciones; set => _idDirecciones = value; }
        public string Residencia { get => _Residencia; set => _Residencia = value; }
        public string Canton { get => _Canton; set => _Canton = value; }
        public string Cacerio { get => _Cacerio; set => _Cacerio = value; }
        public int IdMunicipios { get => _idMunicipios; set => _idMunicipios = value; }


        public Boolean Insertar()
        {
            Boolean Resultado = false;
            String Sentencia;
            Int32 FilasInsertadas = 0;
            try
            {
                Sentencia = @"INSERT INTO direcciones(Residencia,Canton,Cacerio,idMunicipios)
                            VALUES('" + _Residencia + "','" + _Canton + "','" + _Cacerio + "','" + _idMunicipios + "');";
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
                Sentencia = @"UPDATE direcciones SET Residencia='" + _Residencia + "',Canton='" + _Canton + "',Cacerio='" + _Cacerio + "',idMunicipios='" + _idMunicipios + "' " +
                "WHERE idDirecciones=" + _idDirecciones + ";";
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
