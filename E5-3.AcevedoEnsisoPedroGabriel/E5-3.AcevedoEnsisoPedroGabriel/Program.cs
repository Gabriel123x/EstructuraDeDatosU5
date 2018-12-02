using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_3.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Imprimir(int[] arreglo)//metodo que uso para imrpimir el arreglo
        {
            foreach(var item in arreglo)
            {
                Console.Write(" " + item);
            }
        }
        static void Sort(int[] arr)//metodo que utilizamos para ordenar el arreglo
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }
        }
        static void Main(string[] args)
        {
            int[] arreglo1 = new int[] { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };//declaramos nuestros 4 arreglos
            int[] arreglo2 = new int[] { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] arreglo3 = new int[] { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] arreglo4 = new int[] { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] arreglo5 = new int[] { 25, 108, 1024, 12, 351, 251, 39 };
            Console.WriteLine("\nArreglo 1 Desordenado: ");
            Imprimir(arreglo1);//Imrimimos el arreglo
            Sort(arreglo1);//acomodamos el arreglo
            Console.WriteLine("\nArreglo 1 Ordenado: ");
            Imprimir(arreglo1);//lo volvemos a imprimir
            Console.WriteLine("\n");
            //repetimos lo mismo con los otros 4 arreglos
            Console.WriteLine("\nArreglo 2 Desordenado: ");
            Imprimir(arreglo2);
            Sort(arreglo2);
            Console.WriteLine("\nArreglo 2 Ordenado: ");
            Imprimir(arreglo2);
            Console.WriteLine("\n");

            Console.WriteLine("\nArreglo 3 Desordenado: ");
            Imprimir(arreglo3);
            Sort(arreglo3);
            Console.WriteLine("\nArreglo 3 Ordenado: ");
            Imprimir(arreglo3);
            Console.WriteLine("\n");

            Console.WriteLine("\nArreglo 4 Desordenado: ");
            Imprimir(arreglo4);
            Sort(arreglo4);
            Console.WriteLine("\nArreglo 4 Ordenado: ");
            Imprimir(arreglo4);
            Console.WriteLine("\n");

            Console.WriteLine("\nArreglo 5 Desordenado: ");
            Imprimir(arreglo5);
            Sort(arreglo5);
            Console.WriteLine("\nArreglo 5 Ordenado: ");
            Imprimir(arreglo5);
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}


