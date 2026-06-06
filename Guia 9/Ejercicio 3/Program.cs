using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Program
    {
        static Servicio servicio = new Servicio();

        #region SOLICITAR OPCION
        static int MostrarPantallaSolicitarOpcion()
        {
            Console.WriteLine("1-Registrar los nomrbes de los 3 alumnos mas su numero de libreta");
            Console.WriteLine("2-Mostrar lista ordenada");
            Console.WriteLine("3-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR ALUMNOS Y NUMERO DE LIBRETAS
        static void MostrarPantallaSolicitarAlumnosYNumeroDeLibretas()
        {
            Console.WriteLine("Igrensar nombre del primer alumno");
            servicio.nombres[0] = Console.ReadLine();
            Console.WriteLine("Ingrese numero de libreta del primer alumno");
            servicio.numeroLibretas[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Igrensar nombre del segundo alumno");
            servicio.nombres[1] = Console.ReadLine();
            Console.WriteLine("Ingrese numero de libreta del segundo alumno");
            servicio.numeroLibretas[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Igrensar nombre del tecer alumno");
            servicio.nombres[2] = Console.ReadLine();
            Console.WriteLine("Ingrese numero de libreta del tercer alumno");
            servicio.numeroLibretas[2] = Convert.ToInt32(Console.ReadLine());
        }
        #endregion

        #region MOSTRAR LISTA ORDENADA
        static void MostrarPantallaMostrarListaOrdenada()
        {
            if (servicio.numeroLibretas[0] > servicio.numeroLibretas[1] && servicio.numeroLibretas[0] > servicio.numeroLibretas[2])
            {
                if (servicio.numeroLibretas[1] > servicio.numeroLibretas[2])
                {
                    Console.WriteLine("ORDEN DE LISTA");
                    Console.WriteLine($"{servicio.nombres[0]}  |  {servicio.numeroLibretas[0]}");
                    Console.WriteLine($"{servicio.nombres[1]}  |  {servicio.numeroLibretas[1]}");
                    Console.WriteLine($"{servicio.nombres[2]}  |  {servicio.numeroLibretas[2]}");
                }
                else
                {
                    Console.WriteLine("ORDEN DE LISTA");
                    Console.WriteLine($"{servicio.nombres[0]}  |  {servicio.numeroLibretas[0]}");
                    Console.WriteLine($"{servicio.nombres[2]}  |  {servicio.numeroLibretas[2]}");
                    Console.WriteLine($"{servicio.nombres[1]}  |  {servicio.numeroLibretas[1]}");
                }
            }
            else if (servicio.numeroLibretas[1] > servicio.numeroLibretas[0] && servicio.numeroLibretas[1] > servicio.numeroLibretas[2])
            {
                if (servicio.numeroLibretas[0] > servicio.numeroLibretas[2])
                {
                    Console.WriteLine("ORDEN DE LISTA");
                    Console.WriteLine($"{servicio.nombres[1]}  |  {servicio.numeroLibretas[1]}");
                    Console.WriteLine($"{servicio.nombres[0]}  |  {servicio.numeroLibretas[0]}");
                    Console.WriteLine($"{servicio.nombres[2]}  |  {servicio.numeroLibretas[2]}");
                }
                else
                {
                    Console.WriteLine("ORDEN DE LISTA");
                    Console.WriteLine($"{servicio.nombres[1]}  |  {servicio.numeroLibretas[1]}");
                    Console.WriteLine($"{servicio.nombres[2]}  |  {servicio.numeroLibretas[2]}");
                    Console.WriteLine($"{servicio.nombres[0]}  |  {servicio.numeroLibretas[0]}");
                }
            }
            else if (servicio.numeroLibretas[2] > servicio.numeroLibretas[1] && servicio.numeroLibretas[2] > servicio.numeroLibretas[0])
            {
                if (servicio.numeroLibretas[1] > servicio.numeroLibretas[0])
                {
                    Console.WriteLine("ORDEN DE LISTA");
                    Console.WriteLine($"{servicio.nombres[2]}  |  {servicio.numeroLibretas[2]}");
                    Console.WriteLine($"{servicio.nombres[1]}  |  {servicio.numeroLibretas[1]}");
                    Console.WriteLine($"{servicio.nombres[0]}  |  {servicio.numeroLibretas[0]}");
                }
                else
                {
                    Console.WriteLine("ORDEN DE LISTA");
                    Console.WriteLine($"{servicio.nombres[2]}  |  {servicio.numeroLibretas[2]}");
                    Console.WriteLine($"{servicio.nombres[0]}  |  {servicio.numeroLibretas[0]}");
                    Console.WriteLine($"{servicio.nombres[1]}  |  {servicio.numeroLibretas[1]}");
                }
            }
        }
        #endregion

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcion();
                switch (opcion)
                {
                    case 1:
                        {
                            MostrarPantallaSolicitarAlumnosYNumeroDeLibretas(); break;
                        }
                    case 2:
                        {
                            MostrarPantallaMostrarListaOrdenada(); break;
                        }
                    case 3:
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
            }
            while (opcion != 3);
        }
    }
}