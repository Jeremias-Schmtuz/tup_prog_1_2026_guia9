using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Servicio
    {

        #region Variables "GLOBALES"
        private int[] cantidades = new int[5];
        public int numeroTransaccionMayor;
        public double montoTransaccionMayor;
        private int contadorDeTransacciones;
        public double[] porcentajeCantidadRubro = new double[5];
        public double recaudacionTotal;
        #endregion

        #region INICIALIZAR VARIABLES
        public void InicializarVariables()
        {
            for (int i = 0; i < 5; i++)
            {
                cantidades[i] = 0;
                porcentajeCantidadRubro[i] = 0;
            }
            numeroTransaccionMayor = 0;
            contadorDeTransacciones = 0;
            montoTransaccionMayor = 0;
            recaudacionTotal = 0;
        }
        #endregion

        #region EVALUAR TRANSACCION PUNTO DE VENTA
        public void EvaluarTransaccionPuntoDeVenta(int nroTransaccion, int rubro, int cantidad, double monto)
        {
            cantidades[rubro - 1] += cantidad;

            if (monto > montoTransaccionMayor)
            {
                montoTransaccionMayor = monto;
                numeroTransaccionMayor = nroTransaccion;
            }

            recaudacionTotal += monto;
        }
        #endregion

        #region CALCULAR PORCENTAJES Y CANTIDADES DE VENTAS POR RUBRO
        public void CalcularPorcentajesCantidadVentasPorRubro()
        {
            int totalCantidad = cantidades[0] + cantidades[1] + cantidades[2] + cantidades[3] + cantidades[4];
            for (int i =0; i < 5; i++)
            {
                porcentajeCantidadRubro[i] = (double)cantidades[i] / totalCantidad;
            }
        }
        #endregion
    }
}