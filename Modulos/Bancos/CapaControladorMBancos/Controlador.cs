using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CapaModeloMBancos;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace CapaControladorMBancos
{
    public class Controlador
    {
        Sentencias con = new Sentencias();

        public OdbcDataReader llenarcbxAplic() 
        {
            return con.llenarcbxAplicacion();
        }
        public DataTable llenarTb1(string datoa)
        {
            OdbcDataAdapter db = con.llenarTb1(datoa);
            DataTable table = new DataTable();
            db.Fill(table);
            return table;
        }
        public DataTable llenarTb2(string tabla)
        {
            OdbcDataAdapter dt = con.llenarTb2(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public string consultaGeneral1()
        {
            return con.ConsultaGeneral1();
        }
        public OdbcDataReader llenarcbxmoned()
        {
            return con.llenarcbxmoneda();
        }
        public OdbcDataReader IdMoned(string nombreA)
        {
            return con.IdMoneda(nombreA);
        }
        public OdbcDataReader cambioM(string nombreB)
        {
            return con.cambioMoneda(nombreB);
        }
        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = con.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable llenarT(string tabla)
        {
            OdbcDataAdapter dt = con.llenarTb(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Angel Chacón 9959-18-5201 
        //Funcion para obtener el IdAplic
        public OdbcDataReader IdProv(string cadena)
        {
            return con.IdProv(cadena);
        }

        //Angel Chacón 9959-18-5201 
        //Funcion para obtener el nombre de la aplicacion en combobox
        public OdbcDataReader llenarcbxProv()
        {
            return con.llenarcbxProv();
        }


        public string consu(string idProv)
        {
            return con.consu(idProv);
        }

        public string consultaGeneral()
        {
            return con.ConsultaGeneral();
        }
    }
}
