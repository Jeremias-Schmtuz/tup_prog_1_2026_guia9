using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Servicio
    {
        #region Variables "INSTANCIA"
        private int acumulador;
        public int contador;
        public int maximo;
        public int minimo;
        #endregion

        #region CONSTRUCTOR
        public Servicio()
        {
            acumulador = 0;
            contador = 0;
            maximo = 0;
            minimo = 0;
        }
        #endregion

        #region CALCULAR PROMEDIO
        public double CalcularPromedio()
        {
            double promedio = (double)acumulador / contador;
            return promedio;
        }
        #endregion

        #region REGISTRAR VALOR MAXIMO Y MINIMO
        public void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;
            if (contador == 1 || valor > maximo)
            {
                maximo = valor;
            }
            if (contador == 1 || valor < minimo)
            {
                minimo = valor;
            }
        }
        #endregion
    }
}