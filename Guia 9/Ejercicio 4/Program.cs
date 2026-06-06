using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Registrar los nombres de los jugadores");
            Console.WriteLine("2-Registrar los resultados de cada set de los jugadores");
            Console.WriteLine("3-Mostrar el ganador");
            Console.WriteLine("4-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR NOMBRES DE LOS JUGADORES
        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.WriteLine("Ingrese nombre del jugador 1");
            string nombre1 = Console.ReadLine();
            Console.WriteLine("Ingrese nombre del jugador 2");
            string nombre2 = Console.ReadLine();
            servicio.RegistrarJugadores(nombre1, nombre2);
        }
        #endregion

        #region SOLICITAR RESULTADO SET
        static void MostrarPantallaSolicitarResultadoSet()
        {
            for (int i = 0; i < 3; i++)
            Console.WriteLine($"Ingrese el resultado del set {i + 1}");
            Console.WriteLine("Jugador 1.");
            int resultado1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Jugador 2.");
            int resultado2 = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarResultadoSet(resultado1, resultado2);
        }
        #endregion
        #region MOSTRAR GANADOR
        static void MostrarPantallaGanador()
        {
            Console.WriteLine($"El ganador fue {servicio.DeterminarGanador()}");
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
                            MostrarPantallaSolicitarNombreJugadores(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaSolicitarResultadoSet(); break;
                        }
                    case 3:
                        {
                            MostrarPantallaGanador(); break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Saliendo...");
                            Thread.Sleep(2500); break;
                        }
                    default:
                        {
                            Console.WriteLine("Opcion invalida.");
                            Console.WriteLine("Precione cualquier tecla para volver al menu de opciones.");
                            Console.ReadKey(); break;
                        }
                }
            }
            while (opcion != 4);
        }
    }
}