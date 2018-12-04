using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5.AcevedoEnsisoPedroGabriel
{
    class OrdenamienoShell
    {
        private int[] vector;

        public void Cargar()
        {
            string linea;//este codigo esta hecho para que uno ingrese los numeros a vector que desee ordenar
            int cant;
            Console.WriteLine("Metodo de Shell Sort");
            Console.Write("Cuantos elementos tiene el vector? ");
            linea = Console.ReadLine();
            cant = int.Parse(linea);
            vector = new int[cant];//se le da el tamaño que introducimos al vector
            for (int f = 0; f < vector.Length; f++)//con este ciclo pretendemos agregar cada elemento al vector
            {
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                vector[f] = int.Parse(linea);
            }
        }

        public void Shell()//metodo de ordenamiento shellsort
        {
            int salto = 0;
            int sw = 0;
            int auxi = 0;
            int e = 0;
            salto = vector.Length / 2;//el salto que vamos a dar de dato en dato esta dado por la division entre dos de la longitud del arreglo y como el salto es de tipo entero va a redondear cualquier cantidad decimal que sobre automaticamente
            while (salto > 0)//conforme se sigua corriendo este metodo el salto sera cada ves mas pequeño este ciclo seguira repitiendose hasta que el salto sea 0 o menor
            {
                sw = 1;
                while (sw != 0)
                {
                    sw = 0;
                    e = 1;
                    while (e <= (vector.Length - salto))
                    {
                        if (vector[e - 1] > vector[(e - 1) + salto])//comparamos el elemento en la posicion e - 1 osea comenzando desde el principio con el que este salto cantidad despues
                        {//de ser mayor simplemente los cambiamos de lugar usando un vector temporal llamado auxi
                            auxi = vector[(e - 1) + salto];
                            vector[(e - 1) + salto] = vector[e - 1];
                            vector[(e - 1)] = auxi;
                            sw = 1;
                        }
                        e++;
                    }
                }
                salto = salto / 2;//el salto se sigue haciendo mas y mas pequeño
            }
        }

        public void Imprimir()//metodo que usamos para imprimir nuestro vector
        {
            Console.WriteLine("Imprimimos arreglo de mayor a menor");
            for (int f = vector.Length; f > 0; f--)//para asegurarnos de que lo imprima de mayor a menor imprimimos el arreglo ordenado de manera invertida
            {
                Console.Write(vector[f - 1] + "  ");
            }
        }
    }
}
