using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Servicio
    {

        #region Variables "GLOBALES"
        private int indecisos;
        private int negativos;
        private int positivos;
        public double porcentajeIndecisos;
        public double porcentajeNegativos;
        public double porcentajePositivos;
        #endregion

        #region REGISTRAR OPCION
        public void RegistrarOpcion(int opcion)
        {
            if (opcion == 0)
            {
                positivos++;
            }
            else if (opcion == 1)
            {
                negativos++;
            }
            else if (opcion == 2)
            {
                indecisos++;
            }
        }
        #endregion

        #region PROCESAR ENCUESTA
        public void ProcesarEncuesta()
        {
            int total = positivos + negativos + indecisos;
            porcentajePositivos = ((double)positivos / total) * 100;
            porcentajeNegativos = ((double)negativos / total) * 100;
            porcentajeIndecisos = ((double)positivos / total) * 100;
        }
        #endregion

    }
}