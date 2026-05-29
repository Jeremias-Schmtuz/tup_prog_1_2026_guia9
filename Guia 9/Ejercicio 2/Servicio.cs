using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Servicio
    {

        #region Varibales "INSTANCIA" 
        public int edad0;
        public int edad1;
        public int edad2;
        public int edad3;
        public double monto;
        public double porcentaje0;
        public double porcentaje1;
        public double porcentaje2;
        public double porcentaje3;
        public double monto0;
        public double monto1;
        public double monto2;
        public double monto3;
        #endregion

        #region
        public void RegistrarMontoARepartir(double monto)
        {
            this.monto = monto;
        }
        #endregion

        #region REGISTRAR EDAD
        public void RegistrarEdad(int edad, int nroNiña)
        {
            if (nroNiña == 0)
                edad0 = edad;
            else if (nroNiña == 1)
                edad1 = edad;
            else if (nroNiña == 2)
                edad2 = edad;
            else if (nroNiña == 3)
                edad3 = edad;
        }
        #endregion

        public void CalcularMontosYPorcentajesARepartir()
        {
            int sumaEdades = edad0 + edad1 + edad2 + edad3;

            porcentaje0 = (double)edad0 / sumaEdades * 100;
            porcentaje1 = (double)edad1 / sumaEdades * 100;
            porcentaje2 = (double)edad2 / sumaEdades * 100;
            porcentaje3 = (double)edad3 / sumaEdades * 100;

            monto0 = monto * porcentaje0 / 100;
            monto1 = monto * porcentaje1 / 100;
            monto2 = monto * porcentaje2 / 100;
            monto3 = monto * porcentaje3 / 100;
        }
    }
}