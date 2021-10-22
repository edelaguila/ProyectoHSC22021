﻿using Conexion;
using Modelo.DTO;
using System;
using System.Data.Odbc;
using Dapper;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using BitacoraRegistrarLogin.ViewModel;

namespace BitacoraUsuario
{
    public class Bitacora
    {
        private ConexionODBC ODBC = new ConexionODBC();

        //public void guardarEnBitacora(string IdUsuario, string IdAplicacion, string accion)
        //{
        //    string host = Dns.GetHostName();
        //    string ip = "";
        //    IPAddress[] hostIPs = Dns.GetHostAddresses(host);
        //    for (int i = 0; i < hostIPs.Length; i++)
        //    {
        //        ip = hostIPs[i].ToString();
        //    }

        //    dtoBitacora modeloBitacora = new dtoBitacora();
        //    OdbcConnection conexionODBC = ODBC.abrirConexion();
        //    if (conexionODBC != null)
        //    {
        //        var sqlinsertar =
        //        "INSERT INTO bitacorausuario (pkId, host, ip, conexionFecha, conexionHora, fkIdUsuario, fkIdAplicacion, accion) " +
        //        "VALUES (NULL, ?host?, ?ip?, ?conexionFecha?, ?conexionHora?, ?fkIdUsuario?, ?fkIdAplicacion?, ?accion?);";
        //        var ValorDeVariables = new
        //        {
        //            host = host,
        //            ip = ip,
        //            conexionFecha = modeloBitacora.conexionFecha,
        //            conexionHora = modeloBitacora.conexionHora,
        //            fkIdUsuario = IdUsuario,
        //            fkIdAplicacion = IdAplicacion,
        //            accion = accion
        //        };
        //        conexionODBC.Execute(sqlinsertar, ValorDeVariables);
        //        ODBC.cerrarConexion(conexionODBC);
        //    }
        //}

        public void guardarEnBitacora(string IdUsuario, string IdModulo, string IdAplicacion, string accion)
        {
            string host = Dns.GetHostName();
            string ip = "";
            IPAddress[] hostIPs = Dns.GetHostAddresses(host);
            for (int i = 0; i < hostIPs.Length; i++)
            {
                ip = hostIPs[i].ToString();
            }

            dtoBitacora modeloBitacora = new dtoBitacora();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO bitacorausuario (pkId, host, ip, conexionFecha, conexionHora, fkIdUsuario, fkIdAplicacion, accion, fkIdModulo) " +
                "VALUES (NULL, ?host?, ?ip?, ?conexionFecha?, ?conexionHora?, ?fkIdUsuario?, ?fkIdAplicacion?, ?accion?, ?fkIdModulo?);";
                var ValorDeVariables = new
                {
                    host = host,
                    ip = ip,
                    conexionFecha = modeloBitacora.conexionFecha,
                    conexionHora = modeloBitacora.conexionHora,
                    fkIdUsuario = IdUsuario,
                    fkIdAplicacion = IdAplicacion,
                    accion = accion,
                    fkIdModulo = IdModulo
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
        }

        public string obtenerIdDeUsuario(string nombre)
        {
            dtoBitacora modeloBitacora = new dtoBitacora();
            string res = "";
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "SELECT pkId FROM usuario WHERE nombre = ?nombre?;";
                var ValorDeVariables = new
                {
                    nombre = nombre
                };
                res = conexionODBC.Query<string>(sqlinsertar, ValorDeVariables).FirstOrDefault();

                ODBC.cerrarConexion(conexionODBC);
            }
            return res;
        }

        public List<ViewModelBitacora> leerBitacora()
        {
            List<ViewModelBitacora> sqlresultado = new List<ViewModelBitacora>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT A.pkId, B.nombre AS usuario, A.host, A.ip, D.nombre AS modulo, C.nombre AS aplicacion, A.accion AS accion, A.conexionFecha, A.conexionHora FROM bitacorausuario A JOIN usuario B ON A.fkIdUsuario = B.pkId JOIN aplicacion C ON A.fkIdAplicacion = C.pkId JOIN modulo D ON A.fkIdModulo = D.pkId;";
                sqlresultado = conexionODBC.Query<ViewModelBitacora>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
            }
            return sqlresultado;
        }
    }
}