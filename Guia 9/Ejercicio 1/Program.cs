using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static Servicio servicio;

        #region SOLICITAR OPCION MENU
        static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.WriteLine("1-Procesar un solo numero");
            Console.WriteLine("2-Procesar varios numeros");
            Console.WriteLine("3-Mostrar maximo");
            Console.WriteLine("4-Mostrar minimo");
            Console.WriteLine("5-Mostrar promedio");
            Console.WriteLine("6-Mostrar cantidad de numeros ingresados");
            Console.WriteLine("7-Reiniciar variables");
            Console.WriteLine("8-Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        #endregion

        #region SOLICITAR UN NUMERO
        static void MostrarPantallaSolicitarNumero()
        {
            Console.WriteLine("Ingrese un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            servicio.RegistrarValor(numero);
        }
        #endregion

        #region SOLICITAR VARIOS NUMEROS
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            string respuesta;
            do
            {
                MostrarPantallaSolicitarNumero();
                Console.WriteLine("Ingresar otro numero(SI-NO)");
                respuesta = Console.ReadLine();
            }
            while (respuesta == "SI");
        }
        #endregion

        #region MOSTRAR MAXIMO
        static void MostrarPantallaMostrarMaximo()
        {
            Console.WriteLine("El maximo es: " + servicio.maximo);
        }
        #endregion

        #region MOSTRAR MINIMO
        static void MostrarPantallaMostrarMinimo()
        {
            Console.WriteLine("El minimo es: " + servicio.minimo);
        }
        #endregion

        #region MOSTRAR PROMEDIO
        static void MostrarPantallaMostrarPromedio()
        {
            Console.WriteLine("El promedio es: " + servicio.CalcularPromedio());
        }
        #endregion

        #region MOSTRAR CANTIDAD DE NUMEROS INGRESADOS
        static void MostrarCantidadDeNumerosIngresados()
        {
            Console.WriteLine("Cantidad de nuemero ingresados: " + servicio.contador);
        }
        #endregion

        #region REINCIAR VARIBALES
        static void ReiniciarVariables()
        {
            servicio = new Servicio();
            Console.WriteLine("Variables reiniciadas.");
            Thread.Sleep(1500);
        }
        #endregion

        static void Main(string[] args)
        {
            servicio = new Servicio();
            int opcion;
            do
            {
                opcion = MostrarPantallaSolicitarOpcionMenu();
                switch (opcion)
                {
                    case 1: MostrarPantallaSolicitarNumero(); break;
                    case 2: MostrarPantallaSolicitarVariosNumeros(); break;
                    case 3: MostrarPantallaMostrarMaximo(); break;
                    case 4: MostrarPantallaMostrarMinimo(); break;
                    case 5: MostrarPantallaMostrarPromedio(); break;
                    case 6: MostrarCantidadDeNumerosIngresados(); break;
                    case 7: ReiniciarVariables(); break;
                    case 8: Console.WriteLine("Saliendo..."); Thread.Sleep(500); break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.WriteLine("Redirigiendo al menu de opciones...");
                        Thread.Sleep(2500);
                        break;
                }
            }
            while (opcion != 8);
        }
    }
}
