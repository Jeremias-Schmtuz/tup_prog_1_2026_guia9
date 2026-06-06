using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {

        static Servicio servicio = new Servicio();

        #region SOLICITAR OPCIN MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Ingresar opinion");
            Console.WriteLine("2-Procesar y mostrar resultados encuesta");
            Console.WriteLine("3-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region REGISTRAR ENCUESTA
        static void MostrarPantallaRegistrarEncuesta()
        {
            Console.WriteLine("0-Positivo");
            Console.WriteLine("1-Negativo");
            Console.WriteLine("2-Indeciso");
            Console.Write("Ingrese su opinion");
            int opinion = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarOpcion(opinion);
        }
        #endregion

        #region PROCESAR Y MOSTRAR RESULTADOS ENCUESTA
        static void MostrarPantallaProcesarMostrarResultadosEncuesta()
        {
            servicio.ProcesarEncuesta();
            Console.WriteLine("Positivos: " + servicio.porcentajePositivos + "%");
            Console.WriteLine("Negativos: " + servicio.porcentajeNegativos + "%");
            Console.WriteLine("Indecisos: " + servicio.porcentajeIndecisos + "%");
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
                            MostrarPantallaRegistrarEncuesta(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaProcesarMostrarResultadosEncuesta(); break;
                        }
                    case 3:
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
            while (opcion != 3);

        }
    }
}