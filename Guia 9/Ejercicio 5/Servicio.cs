using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Servicio
    {

        #region DETERMINAR LOS DIAS DEL MES
        public int DeterminarLosDiasDelMes(int mes, int año)
        {
            int dias;
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                dias = 31;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                dias = 30;
            }
            else
            {
                if (DeterminarSiEsBisiesto(año))
                {
                    dias = 29;
                }
                else
                {
                    dias = 28;
                }
            }
            return dias;
        }
        #endregion

        #region DETERMINAR SI ES BISIESTO
        public bool DeterminarSiEsBisiesto(int año)
        {
            if (año % 4 == 0 && año % 100 != 0)
            {
                return true;
            }
            else if (año % 400 == 0)
                return true;
            else
            {
                return false;
            }
        }
        #endregion
    }
}
