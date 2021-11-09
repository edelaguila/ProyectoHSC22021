using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Collections;
using System.Data;

namespace Modelo
{
    public class Sentencias
    {
        Conexion con = new Conexion();
        //Hecho por Wilber Enrique Segura Ramirez 0901-18-13952
        public OdbcDataAdapter llenarTabla(string tabla)//Método Genérico para llenar tabla
        {
            Conexion cn = new Conexion();//Variable para abrir conexión
            string sql = "select * from " + tabla + ";";//Aquí ponemos la tabla 
            OdbcConnection conn = cn.conexion();//Abrimos conexión
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, conn);
            cn.desconexion(conn);//Cerramos conexión

            return dataTable;
        }

 
        //metodo de insertar para tipoPoliza Melissa Aldana 0901-18-335 27/10/2021
        public bool ingresoTipoPoliza(string idTipoPoliza, string descripcion)  //ingresoTipoPoliza
        {
            int i = 0;
            try
            {
                string cadena = "insert into tipoPoliza values ('" + idTipoPoliza + "','" + descripcion + "','A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //ingreso tipo Cuenta Kevin González 24/10/2021
        public bool ingresotipoCuenta(string idTipoCuenta, string nombre)  //ingresoTipoPoliza
        {
            int i = 0;
            try
            {
                string cadena = "insert into tipoCuenta values ('" + idTipoCuenta + "','" + nombre + "','A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //metodo de insertar para polizaEncabezado Melissa Aldana 0901-18-335 03/11/2021
        public bool ingresoPolizaEncabezado(string idPolizaEncabezado, string fechaPoliza, string idTipoPoliza)
        {
            int i = 0;
            try
            {
                string cadena = "insert into polizaencabezado values ('" + idPolizaEncabezado + "','" + fechaPoliza + "','" + idTipoPoliza + "');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //metodo de insertar para TipoOperacion Melissa Aldana 0901-18-335 05/11/2021
        public bool ingresoTipoOperacion(string idTipoOperacion, string nombre)
        {
            int i = 0;
            try
            {
                string cadena = "insert into tipooperacion values ('" + idTipoOperacion + "','" + nombre + "','A');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //metodo de insertar para PolizaDetalle Melissa Aldana 0901-18-335 05/11/2021
        public bool ingresoPolizaDetalle(string idPolizaEncabezado, string fechaPoliza, string idCuenta, string saldo, string idTipoOperacion, string concepto)
        {
            int i = 0;
            try
            {
                string cadena = "insert into polizadetalle values ('" + idPolizaEncabezado + "','" + fechaPoliza + "','" + idCuenta + "','" + saldo + "','" + idTipoOperacion + "','" + concepto + "');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //ingreso Cuenta Kevin González 0901-18-1387 05-01-2021
        public bool ingresoCuenta(String idCuenta, String nombre, String idTipoCuenta, String cargo, String abono, String saldoAcumulado, String IdPadre)
        {
            int i = 0;
            try
            {
                string cadena = "insert into cuenta values ('" + idCuenta + "','" + nombre + "','" + idTipoCuenta +  "','" + cargo + "','"  + abono +  "','" + saldoAcumulado + "','A" +"','" + IdPadre + "'); ";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;

            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);



            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Actualizar Poliza detalle Kevin González 0901-18-1387 06/11/2021
        public bool modificarPolizaDetalle(string idPolizaEncabezado, string fechaPoliza, string idCuenta,string saldo, string idTipoOperacion, string concepto)
        {
            int i = 0;
            try
            {
                string cadena = "update polizaDetalle SET fechaPoliza = '" + fechaPoliza + "' ,idCuenta= '" + idCuenta + "' ,saldo= " + saldo +  " ,idTipoOperacion= '" + idTipoOperacion + "' ,concepto= '" + concepto + "' where idPolizaEncabezado='" + idPolizaEncabezado +"';";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al modificar privilegio" + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        //Actualizar Poliza Encabezado Melissa Aldana 0901-18-335 06/11/2021
        public bool modificarPolizaEncabezado(string idPolizaEncabezado, string fechaPoliza, string idTipoPoliza)
        {
            int i = 0;
            try
            {
                string cadena = "update polizaencabezado SET fechaPoliza = '" + fechaPoliza + "' ,idTipoPoliza= '" + idTipoPoliza +  "' where idPolizaEncabezado='" + idPolizaEncabezado + "';";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al modificar privilegio" + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        //Actualizar Poliza detalle Kevin González 0901-18-1387 06/11/2021
        public bool modificarCuenta(string idCuenta, string nombre, string idTipoCuenta, string cargo, string abono, string saldoAcumulado, string estado, string idCuentaPadre)
        {
            int i = 0;
            try
            {
                string cadena = "update cuenta SET nombre = '" + nombre + "' ,idTipoCuenta= '" + idTipoCuenta + "' ,cargo= " + cargo + " ,abono= " + abono + " ,saldoAcumulado= " + saldoAcumulado + " ,estado= '" + estado + "' ,idCuentaPadre= '" + idCuentaPadre  +"' where idCuenta='" + idCuenta + "';";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
                i = 1;
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al modificar privilegio" + Error);

            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
