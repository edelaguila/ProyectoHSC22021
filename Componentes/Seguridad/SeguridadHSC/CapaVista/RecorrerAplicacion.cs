using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaControladorSeguridadHSC;
using System.Collections;

namespace CapaVistaSeguridadHSC
{
    public class RecorrerAplicacion
    {
        //funcion habilitar aplicacion  Ashly Barrios 9959-18-649
        //5-11-2021
        private ControladorPermisoAplicacion permisoApp = new ControladorPermisoAplicacion();
        public int comprobar(string modulo, string usuario, string aplicacion, int validar)
        {

            validar = permisoApp.habilitarApp(modulo, usuario, aplicacion, validar);
            return validar;


        }
    }
}
