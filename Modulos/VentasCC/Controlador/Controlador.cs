using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModeloMVentasCC;

namespace CapaControladorMVentasCC
{
    public class Controlador
    {
        private Sentencias sn = new Sentencias();

        //Mantenimiento Clientes Kevin Flores 9959-18-17632
        public void llamarInsertCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funInsertarCliente(id, nit, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarModifCliente(string id, string nit, string nombre, string apellido, string direccion, string telefono, string estado)
        {

            sn.funModifCliente(id, nit, nombre, apellido, direccion, telefono, estado);
        }

        public void llamarElimCliente(string id)
        {

            sn.funElimCliente(id);
        }
        public DataTable llenarCliente(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarCliente(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Mantenimiento Fraccionamiento  Kevin Flores 9959-18-17632

        //Mantenimiento inventarios Heydi Quemé 9959-18-5335
        public void llamarInsertProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {

            sn.funInsertarProducto(id, nombre, costo, precio, existencias, estado);
        }

        public void llamarModifProducto(string id, string nombre, string costo, string precio, string existencias, string estado)
        {

            sn.funModifProducto(id, nombre, costo, precio, existencias, estado);
        }

        public void llamarElimProducto(string id)
        {

            sn.funElimProducto(id);
        }
        public DataTable llenarProducto(string tabla1)
        {
            OdbcDataAdapter dt = sn.llenarProducto(tabla1);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Mantenimiento tipo inventario Heydi Quemé 9959-18-5335

        //Mantenimiento Mora Kevin Flores 9959-18-17632

        //Mantenimiento tipo Documento Kevin Flores 9959-18-17632 


        //Mantenimiento Movimiento Danny Saldaña 0901-18-18686s

        public DataTable INVMostarMovimientos()
        {
            OdbcDataAdapter dt = sn.INVMostarMovimientos();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Mantenimiento Lista de precios Danny Saldaña 0901-18-18686
        public DataTable LISTAllenarcbxInventarios()
        {
            OdbcDataAdapter dt = sn.LISTAllenarcbxInventarios();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable LISTAllenarcbxMarca()
        {
            OdbcDataAdapter dt = sn.LISTAllenarcbxMarca();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable LISTAllenarcbxLinea()
        {
            OdbcDataAdapter dt = sn.LISTAllenarcbxLinea();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }


        public void LISTAGlobalYFijo(float Precio)
        {
            sn.LISTAGlobalYFijo(Precio);
        }

        public void LISTAGlobalYDescuento(float Precio)
        {
            sn.LISTAGlobalYDescuento(Precio);
        }

        public void LISTAGlobalYAumento(float Precio)
        {
            sn.LISTAGlobalYAumento(Precio);
        }

        public void LISTATipoYFijo(float Valor, string Fktipoinventario)
        {
            sn.LISTATipoYFijo(Valor, Fktipoinventario);
        }

        public void LISTATipoYDescuento(float Valor, string Fktipoinventario)
        {
            sn.LISTATipoYDescuento(Valor, Fktipoinventario);
        }

        public void LISTATipoYAumento(float Valor, string Fktipoinventario)
        {
            sn.LISTATipoYAumento(Valor, Fktipoinventario);
        }



        public void LISTAMarcaYFijo(float Valor, string Fktipoinventario)
        {
            sn.LISTAMarcaYFijo(Valor, Fktipoinventario);
        }

        public void LISTAMarcaYDescuento(float Valor, string Fktipoinventario)
        {
            sn.LISTAMarcaYDescuento(Valor, Fktipoinventario);
        }

        public void LISTAMarcaYAumento(float Valor, string Fktipoinventario)
        {
            sn.LISTAMarcaYAumento(Valor, Fktipoinventario);
        }




        public void LISTALineaYFijo(float Valor, string Fktipoinventario)
        {
            sn.LISTALineaYFijo(Valor, Fktipoinventario);
        }

        public void LISTALineaYDescuento(float Valor, string Fktipoinventario)
        {
            sn.LISTALineaYDescuento(Valor, Fktipoinventario);
        }

        public void LISTALineaYAumento(float Valor, string Fktipoinventario)
        {
            sn.LISTALineaYAumento(Valor, Fktipoinventario);
        }









        /*

        //Mantenimiento inventarios Danny Saldaña 0901-18-18686............................................................
        public DataTable INVMostarInventarios()
        {
            OdbcDataAdapter dt = sn.INVMostarInventarios();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void INVInsertarInventarios(string Pkid, string Nombre, string Fktipoinventario, string Fkidmarca, string Fkidlinea, int Stock, float Costo, float Precio, string Estatus)
        {
            sn.INVInsertarInventarios(Pkid, Nombre, Fktipoinventario, Fkidmarca, Fkidlinea, Stock, Costo, Precio, Estatus);

        }

        public void INVActualizarInventarios(string Pkid, string Nombre, string Fktipoinventario, string Fkidmarca, string Fkidlinea, int Stock, float Costo, float Precio, string Estatus)
        {
            sn.INVActualizarInventarios(Pkid, Nombre, Fktipoinventario, Fkidmarca, Fkidlinea, Stock, Costo, Precio, Estatus);

        }

        public void INVBorrarInventarios(string Pkid)
        {
            sn.INVBorrarInventarios(Pkid);

        }

        public OdbcDataReader INVllenarcbxTipoInventarios()
        {
            string sql = "SELECT nombre FROM TipoInventario;";
            return sn.INVllenarcbxTipoInventarios(sql);
        }

        public OdbcDataReader INVllenarcbxMarca()
        {
            string sql = "SELECT nombre FROM marca;";
            return sn.INVllenarcbxMarca(sql);
        }

        public OdbcDataReader INVllenarcbxLinea()
        {
            string sql = "SELECT nombre FROM linea;";
            return sn.INVllenarcbxLinea(sql);
        }

        public DataTable INVObtenerIdTipoInventario(string TipoInventario)
        {
            OdbcDataAdapter dt = sn.INVObtenerIdTipoInventario(TipoInventario);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable INVObtenerIdMarca(string Marca)
        {
            OdbcDataAdapter dt = sn.INVObtenerIdMarca(Marca);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public DataTable INVObtenerIdLinea(string Linea)
        {
            OdbcDataAdapter dt = sn.INVObtenerIdLinea(Linea);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        //Mantenimiento tipo inventario Danny Saldaña 0901-18-18686........................................................
        public DataTable INVMostarTipoInventarios()
        {
            OdbcDataAdapter dt = sn.INVMostarTipoInventarios();
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }

        public void INVInsertarTipoInventarios(string Pkid, string Nombre, string Estatus)
        {
            sn.INVInsertarTipoInventarios(Pkid, Nombre, Estatus);

        }

        public void INVActualizarTipoInventarios(string Pkid, string Nombre, string Estatus)
        {
            sn.INVActualizarTipoInventarios(Pkid, Nombre, Estatus);

        }

        public void INVBorrarTipoInventarios(string Pkid)
        {
            sn.INVBorrarTipoInventarios(Pkid);

        }

        */

    }
}
