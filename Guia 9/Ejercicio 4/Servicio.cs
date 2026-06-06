using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    internal class Servicio
    {
        #region Varbiales "GLOBALES"
        string jugador1, jugador2;
        int setGanados1, setGanados2;
        #endregion

        #region REGISTRAR JUGADORES
        public void RegistrarJugadores(string nombre1, string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }
        #endregion

        #region REGISTRAR RESULTADOS X SET
        public void RegistrarResultadoSet(int resultado1, int resultado2)
        {
                if (resultado1 > resultado2)
                {
                    setGanados1++;
                }
                else
                {
                    setGanados2++;
                }
            }
        }
        #endregion

        #region DETERMINAR GANADOR
        public string DeterminarGanador()
        {
            if (setGanados1 > setGanados2)
            {
                Console.WriteLine("El ganador es el jugador 1");
                return jugador1;
            }
            else
            {
                Console.WriteLine("El ganador es el jugador 2");
                return jugador2;
            }
        }
        #endregion
    }
}