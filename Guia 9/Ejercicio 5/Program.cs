using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1- Determinar la cantidad de dias del mes");
            Console.WriteLine("2- Verificar si el año es bisiesto");
            Console.WriteLine("3- Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR MES AÑO Y DETERMINAR DIAS
        static void MostrarPantallaSolicitarMesAñoYDeterminarDias()
        {
            Console.WriteLine("Ingrese el mes");
            int mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el año");
            int año = Convert.ToInt32(Console.ReadLine());
            int dias = servicio.DeterminarLosDiasDelMes(mes, año);
            Console.WriteLine("El mes tiene " + dias + " dias");
        }
        #endregion

        #region VERIFICAR SI EL AÑO ES BISIESTO
        static void MostrarPantallaVerifcarSiElAñoEsBisiesto()
        {
            Console.WriteLine("Ingrese el año");
            int año = Convert.ToInt32(Console.ReadLine());
            if (servicio.DeterminarSiEsBisiesto(año))
            {
                Console.WriteLine("El año " + año + " es bisiesto");
            }
            else
            {
                Console.WriteLine("El año " + año + " no es bisiesto");
            }
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
                            MostrarPantallaSolicitarMesAñoYDeterminarDias(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaVerifcarSiElAñoEsBisiesto(); break;
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