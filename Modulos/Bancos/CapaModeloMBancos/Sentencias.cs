using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace CapaModeloMBancos
{
    public class Sentencias
    {
        Conexion cn = new Conexion();
        public OdbcDataReader llenarcbxAplicacion() 
        {
            string sql = "SELECT idCuenta FROM hotelsancarlos.cuenta;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataAdapter llenarTb1(string datoa)
        {
            string sql = "Select * FROM cuenta where idCuenta = '" + datoa + "' ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenarTb2(string tabla)// metodo  que obtinene el contenio de una tabla en la BD
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }
        public string ConsultaGeneral1()
        {

            string query = "select SUM(saldoAcumulado) from cuenta;";
            OdbcCommand cm = new OdbcCommand(query, cn.conexion());
            OdbcDataReader reg = cm.ExecuteReader();

            if (reg.Read())
            {
                return reg["SUM(saldoAcumulado)"].ToString();
            }
            else
            {
                return "Null";
            }

        }
        public OdbcDataReader llenarcbxmoneda()
        {
            string sql = "SELECT nombreMoneda FROM hotelsancarlos.moneda;";
            try
            {
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public OdbcDataReader IdMoneda(string nombreA)//conexion para obtener el IdAplicacion para el Combobox
        {
            string cadena = "Select Pkid from moneda where nombreMoneda = '" + nombreA + "';";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }
        public OdbcDataReader cambioMoneda(string nombreB)//conexion para obtener el IdAplicacion para el Combobox
        {
            string cadena = "Select cambioTipoC from tipocambio where fkidMoneda = '" + nombreB + "';";
            try
            {
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM chequesprov where idProveedor = '" + tabla + "';";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        public OdbcDataAdapter llenarTb(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, cn.conexion());
            return dataTable;
        }

        //Angel Chacón 9959-18-5201        
        public OdbcDataReader IdProv(string nombreA)//conexion para obtener el IdAplicacion para el Combobox
        {
            try
            {
                string cadena = "Select idProveedor from proveedor where nombre = '" + nombreA + "';";
                OdbcCommand consulta = new OdbcCommand(cadena, cn.conexion());
                OdbcDataReader leer = consulta.ExecuteReader();
                return leer;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en Capa Modelo --> Consultas: " + e);
                return null;
            }
        }

        //Funcion para obtener el IdModulo        
        public OdbcDataReader llenarcbxProv()//conexion para obtener el nombre de la aplicacion en combobox
        {
            try
            {
                string sql = "SELECT Nombre FROM proveedor;";
                OdbcCommand datos = new OdbcCommand(sql, cn.conexion());
                OdbcDataReader leer = datos.ExecuteReader();
                return leer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        //Funcion para obtener el total de cheques        
        public string consu(string idP)
        {

            string query = "select SUM(MontoTotal) from chequesprov where idProveedor = '" + idP + "';";
            OdbcCommand cm = new OdbcCommand(query, cn.conexion());
            OdbcDataReader reg = cm.ExecuteReader();

            if (reg.Read())
            {
                return reg["SUM(MontoTotal)"].ToString();
            }
            else
            {
                return "Null";
            }

        }

        public string ConsultaGeneral()
        {

            string query = "select SUM(MontoTotal) from chequesprov;";
            OdbcCommand cm = new OdbcCommand(query, cn.conexion());
            OdbcDataReader reg = cm.ExecuteReader();

            if (reg.Read())
            {
                return reg["SUM(MontoTotal)"].ToString();
            }
            else
            {
                return "Null";
            }

        }


    }
}
