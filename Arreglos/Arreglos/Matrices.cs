using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    public class Matrices
    {
        private int[,] matriz;

        public Matrices() {
            matriz = new int[4, 2];
        }
        public void inicializarMatriz()
        {
            for (int i=0; i < 4; i++) {
                for (int j=0; j < 2; j++) {
                    matriz[i, j] = i + j;
                }
            }
        }

        public void imprimirMatriz() {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ",matriz[i, j]);
                }
                Console.WriteLine("");
            }

        }

    }
}
