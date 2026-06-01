using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("1-Iniciar monto a repartir");
            Console.WriteLine("2-Solicitar edad por niña");
            Console.WriteLine("3-Mostrar monto y porcentajes por niña");
            Console.WriteLine("4-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR MONTO A REPARTIR
        static void MostrarPantallaSolicitarMontoARepartir()
        {
            Console.Clear();
            Console.Write("Ingrese el monto total a repartir: ");
            double monto = double.Parse(Console.ReadLine());
            servicio.RegistrarMontoARepartir(monto);
        }
        #endregion

        #region SOLICITAR EDADES DE LAS NIÑAS
        static void MostrarPantallaSolicitarEdadesNiñas()
        {
            Console.Clear();
            Console.Write("Ingrese la edad de Ana Paula: ");
            int edad = int.Parse(Console.ReadLine());
            servicio.RegistrarEdad(edad, 0);
            Console.Write("Ingrese la edad de Lucía: ");
            edad = int.Parse(Console.ReadLine());
            servicio.RegistrarEdad(edad, 1);
            Console.Write("Ingrese la edad de Milena: ");
            edad = int.Parse(Console.ReadLine());
            servicio.RegistrarEdad(edad, 2);
            Console.Write("Ingrese la edad de Jazmín: ");
            edad = int.Parse(Console.ReadLine());
            servicio.RegistrarEdad(edad, 3);
        }
        #endregion

        #region CALCULAR Y MOSTRAR MONTO Y PORCENTAJE POR NIÑA
        static void MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña()
        {
            Console.Clear();
            servicio.CalcularMontosYPorcentajesARepartir();
            Console.WriteLine($"Ana Paula - Porcentaje: {servicio.porcentajes[0]:F2}%  Monto: ${servicio.montos[0]:F2}");
            Console.WriteLine($"Lucía - Porcentaje: {servicio.porcentajes[1]:F2}%  Monto: ${servicio.montos[1]:F2}");
            Console.WriteLine($"Milena - Porcentaje: {servicio.porcentajes[2]:F2}%  Monto: ${servicio.montos[2]:F2}");
            Console.WriteLine($"Jazmín - Porcentaje: {servicio.porcentajes[3]:F2}%  Monto: ${servicio.montos[3]:F2}");
            Console.WriteLine("\nPresione una tecla para volver al menú...");
            Console.ReadKey();
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
                            MostrarPantallaSolicitarMontoARepartir(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaSolicitarEdadesNiñas(); break;
                        }
                    case 3:
                        {
                            MostrarPantallaCalcularMostrarMontoYPorcentajePorNiña(); break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Saliendo..."); Thread.Sleep(500); break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion invalida");
                            Console.WriteLine("Redirigiendo al menu de opciones...");
                            Thread.Sleep(2500);
                            break;
                        }
                }
            } while (opcion != 4);
        }
    }
}