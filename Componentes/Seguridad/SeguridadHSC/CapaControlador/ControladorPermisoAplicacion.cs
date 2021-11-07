using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CapaModeloSeguridadHSC;

namespace CapaControladorSeguridadHSC
{
    public class ControladorPermisoAplicacion
    {
        //funcion habilitar aplicacion  Ashly Barrios 9959-18-649
        //5-11-2021
        private PermisosAplicacion sn = new PermisosAplicacion();
        public int habilitarApp(string modulo, string usuario, string aplicacion, int validar)
        {
            validar = sn.funHabilitarAp(modulo, usuario, aplicacion, validar);
            return validar;
        }
    }
}
