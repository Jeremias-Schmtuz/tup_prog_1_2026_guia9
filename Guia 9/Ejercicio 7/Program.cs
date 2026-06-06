using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    internal class Program
    {

        static Servicio servicio = new Servicio();

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Ingresar un resumen de venta");
            Console.WriteLine("2-Mostrar numero de transaccion con mayor monto");
            Console.WriteLine("3-Mostrar porcentaje de cantidad por rubro");
            Console.WriteLine("4-Mostrar la recaudacion total");
            Console.WriteLine("5-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region REGISTRAR TRANSACCION
        static void MostrarPantallaRegistrarTransaccion()
        {
            Console.WriteLine("Ingrese el numero de transaccion");
            int nroTransaccion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el rubro (1-5)");
            int rubro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de productos vendidos");
            int cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el monto total");
            double monto = Convert.ToDouble(Console.ReadLine());
            servicio.EvaluarTransaccionPuntoDeVenta(nroTransaccion, rubro, cantidad, monto);
        }
        #endregion

        #region MOSTRAR PORCENTAJE DE CANTIDADES POR RUBRO
        static void MostrarPantallaPorcentajeDeCantidadesPorRubro()
        {
            servicio.CalcularPorcentajesCantidadVentasPorRubro();
            Console.WriteLine($"Rubro 1: {servicio.porcentajeCantidadRubro[0]} %");
            Console.WriteLine($"Rubro 2: {servicio.porcentajeCantidadRubro[1]} %");
            Console.WriteLine($"Rubro 3: {servicio.porcentajeCantidadRubro[2]} %");
            Console.WriteLine($"Rubro 4: {servicio.porcentajeCantidadRubro[3]} %");
            Console.WriteLine($"Rubro 5: {servicio.porcentajeCantidadRubro[4]} %");
        }
        #endregion
        static void Main(string[] args)
        {
        }
    }
}
