using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5.AcevedoEnsisoPedroGabriel
{
    class OrdenamientoRadix
    {
        private int[] vector;
        public void Cargar()
        {
            vector = new int[80];//aqui generamos ya nuestro vector de 80 elementos
            Random r = new Random();
            for(int i = 0; i < vector.Length; i++)//en este ciclo for llenaremos el vector de numeros aleatorios no repetidos 
            {
                int aleatorio = r.Next(0, 1000);//decidi hacer que cada numero este entre 0 y 999
                if(!vector.Contains(aleatorio))//si el vector no contiene el numero generado entonces lo agregamos en la posicion adecuada
                {
                    vector[i] = aleatorio;
                }
                else//de no ser asi el iclo continua hasta encontrar un numero no repetido
                {
                    i--;//le restamos uno a i para que el ciclo continue
                }
            }
        }
        public void Imprimir()//metodo que usamos para imprimir nuestro vector
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
        public void Radix()//metodo que utilizamos para ordenar el arreglo con radix
        {
            int i, j;
            int[] tmp = new int[vector.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < vector.Length; ++i)
                {
                    bool move = (vector[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        vector[i - j] = vector[i];
                    else
                        tmp[j++] = vector[i];
                }
                Array.Copy(tmp, 0, vector, vector.Length - j, j);
            }
        }
    }
}
