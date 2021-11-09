using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data;
using System.Data.Odbc;
using System.Collections;


namespace Controlador
{
    public class Controlador
    {
        Sentencias sn = new Sentencias();

        //Hecho por Wilber Enrique Segura Ramirez 0901-18-13952
        public DataTable llenarTabla(string tabla)//Método Genérico para llenar datagrids
        {
            OdbcDataAdapter dt = sn.llenarTabla(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        




        //Melissa Aldana 0901-18-335 27/10/2021
        public bool ingresoTipoPoliza(string idTipoPoliza, string descripcion)
        {
            return sn.ingresoTipoPoliza(idTipoPoliza, descripcion);

        }


        //Kevin González 0901-18-1387 24/10/2021
        public bool ingresotipoCuenta(string idTipoCuenta, string nombre)
        {
            return sn.ingresotipoCuenta(idTipoCuenta, nombre);

        }

        //Melissa Aldana 0901-18-335 3/11/2021
        public bool ingresoPolizaEncabezado(string idPolizaEncabezado, string fechaPoliza, string idTipoPoliza)
        {
            return sn.ingresoPolizaEncabezado(idPolizaEncabezado, fechaPoliza, idTipoPoliza);

        }



        //Melissa Aldana 0901-18-335 5/11/2021
        public bool ingresoTipoOperacion(string idTipoOperacion, string nombre)
        {
            return sn.ingresoTipoOperacion(idTipoOperacion, nombre);

        }


        //Melissa Aldana 0901-18-335 5/11/2021
        public bool ingresoPolizaDetalle(string idPolizaEncabezado, string fechaPoliza, string idCuenta, string saldo, string idTipoOperacion, string concepto)
        {
            return sn.ingresoPolizaDetalle(idPolizaEncabezado, fechaPoliza, idCuenta,  saldo, idTipoOperacion, concepto);

        }


        //Kevin González 0901-18-1387 05/11/2021
        public bool ingresoCuenta(String idCuenta, String nombre, String idTipoCuenta, String cargo, String abono, String saldoAcumulado,  String IdPadre)
        {
            return sn.ingresoCuenta(idCuenta, nombre, idTipoCuenta, cargo, abono, saldoAcumulado, IdPadre);

        }

        //Kevin González 0901-18-1387 06/11/2021
        public bool modificarPolizaDetalle(string idPolizaEncabezado, string fechaPoliza, string idCuenta, string saldo, string idTipoOperacion, string concepto)
        {
            return sn.modificarPolizaDetalle(idPolizaEncabezado, fechaPoliza, idCuenta, saldo, idTipoOperacion, concepto);

        }

        //Melissa Aldana 0901-18-335 06/11/2021
        public bool modificarPolizaEncabezado(string idPolizaEncabezado, string fechaPoliza, string idTipoPoliza)
        {
            return sn.modificarPolizaEncabezado(idPolizaEncabezado, fechaPoliza,  idTipoPoliza);

        }


        //Kevin González 0901-18-1387 06/11/2021
        public bool modificarCuenta(string idCuenta, string nombre, string idTipoCuenta, string cargo, string abono, string saldoAcumulado, string estado, string idCuentaPadre)
        {
            return sn.modificarCuenta(idCuenta, nombre,  idTipoCuenta, cargo,  abono,  saldoAcumulado,  estado,idCuentaPadre);

        }

    }
}
