using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Servicio
    {
        #region Varibales "GLOBALES"
        public string[] nombres = new string[3];
        public int[] numeroLibretas = new int[3];
        public int orden;
        #endregion

        #region REGISTRAR NOMBRE Y NUMERO DE LIBRETA
        public void RegistrarNombreYNumeroDeLibreta(string nombre, int numeroLibreta)
        {
            orden++;
            if (orden == 1)
            {
                nombre = nombres[0];
                numeroLibreta = numeroLibretas[0];
            }
            else if (orden == 2)
            {
                nombre = nombres[1];
                numeroLibreta = numeroLibretas[1];
            }
            else if (orden == 3)
            {
                nombre = nombres[2];
                numeroLibreta = numeroLibretas[2];
            }
        }
        #endregion
    }
}