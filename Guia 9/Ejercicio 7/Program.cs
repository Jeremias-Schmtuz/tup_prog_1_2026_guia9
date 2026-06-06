using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

        #region TRANSACCION MAYOR MONTO
        static void MostrarPantallaTransaccionMayorMonto()
        {
            Console.WriteLine("Numero de transaccion: " + servicio.numeroTransaccionMayor);
            Console.WriteLine("Monto: " + servicio.montoTransaccionMayor);
        }
        #endregion

        #region MONTO RECAUDADO TOTAL
        static void MostrarPantallaMontoRecaudadoTotal()
        {
            Console.WriteLine("Recaudacion total: " + servicio.recaudacionTotal);
        }
        #endregion

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1:
                        {
                            MostrarPantallaRegistrarTransaccion(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaPorcentajeDeCantidadesPorRubro(); break;
                        }
                    case 3:
                        {
                            MostrarPantallaTransaccionMayorMonto(); break;
                        }
                    case 4:
                        {
                            MostrarPantallaMontoRecaudadoTotal(); break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Saliendo...");
                            Thread.Sleep(2500); break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion invalida.");
                            Console.WriteLine("Precione cualquier tecla volver al menu de opciones");
                            Console.ReadKey(); break;
                        }
                }
            }
            while (opcion != 5);
        }
    }
}