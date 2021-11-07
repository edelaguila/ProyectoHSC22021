using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;

namespace CapaModeloSeguridadHSC
{
    public class PermisosAplicacion
    {
        Conexion cn = new Conexion();
        private OdbcCommand Comm;
        //funcion habilitar aplicacion  Ashly Barrios 9959-18-649
        //5-11-2021
        public int funHabilitarAp(string idModulo, string idUsuario, string idApp, int validar)
        {

            try
            {
                string query = "SELECT fkIdAplicacion " +
                    "FROM aplicacion INNER JOIN usuarioaplicacion " +
                    "ON usuarioaplicacion.fkIdAplicacion = aplicacion.pkId where aplicacion.fkIdModulo = " + idModulo +
                    " and usuarioaplicacion.fkIdUsuario = " + idUsuario + " and fkIdAplicacion = " + idApp + ";";
                string idAp = "";


                Comm = new OdbcCommand(query, cn.conexion());
                OdbcDataReader reader = Comm.ExecuteReader();

             

                if (reader.Read())
                {
                    idAp = reader["fkIdAplicacion"].ToString();
                }
                
                validar = idApp.CompareTo(idAp);
                //validar = String.Compare(idAp, idApp, comparisonType: StringComparison.OrdinalIgnoreCase);


                



            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al consular usuario:  " + ex);
                return 1;
            }
            return validar;
        }

        
        }

    }


