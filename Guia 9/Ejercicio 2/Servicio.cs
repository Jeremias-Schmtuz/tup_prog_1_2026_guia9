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

        public int[] edades = new int [4];
        public double[] porcentajes = new double [4];
        public double[] montos = new double [4];
        public double monto;
        #endregion

        #region REGISTRAR MONTO A REPARTIR
        public void RegistrarMontoARepartir(double monto)
        {
            this.monto = monto;
        }
        #endregion

        #region REGISTRAR EDAD
        public void RegistrarEdad(int edad, int nroNiña)
        {
            if (nroNiña == 0)
                edades[ 0] = edad;
            else if (nroNiña == 1)
                edades[1] = edad;
            else if (nroNiña == 2)
                edades[2] = edad;
            else if (nroNiña == 3)
                edades[3] = edad;
        }
        #endregion

        #region CALCULAR MONTOS Y PORCENTAJES A REPARTIR
        public void CalcularMontosYPorcentajesARepartir()
        {
            int sumaEdades = 0;
            for (int a = 0; a < 4; a++)
            {
                sumaEdades += edades[a];
            }
            for(int i = 0; i < 4; i++)
            {
                porcentajes[i] = (double)edades[i] / sumaEdades * 100;
                montos[i] = monto * porcentajes[i] / 100;
            }
        }
        #endregion
    }
}