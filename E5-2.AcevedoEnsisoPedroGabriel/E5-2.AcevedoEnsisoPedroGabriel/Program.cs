using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_2.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] NumerosA = { 11, 2, 3, 14, 18, 4, 5, -3, -1, 6, 9 };//mis 4 arreglos de numeros en este caso son double por ser de numeros con decimales algunos
            double[] NumerosB = { 1, 3, 5, 7, 8, 9, 0.7071, 16.56, 12, 0, 10 };
            double[] NumerosC = { 3, 7, 15, 1.33, 155, 100, 12, 1.732, 5, 2 };
            double[] NumerosD = { 8, 19, 7, 3, 15, 23, 34, 27, 89, 101 };

            Console.WriteLine("Primer arrgelo de numeros en desorden");
            Imprimir(NumerosA);//imprimo los numeros para ver que estan en desorden
            QuickSort(NumerosA);//los ordeno
            Console.WriteLine("Numeros en ordenados despues de quicksort");
            Imprimir(NumerosA);//los vuelvo a imprmir para comprovar que el metodo funciona
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Segundo arrgelo de numeros en desorden");
            Imprimir(NumerosB);
            QuickSort(NumerosB);
            Console.WriteLine("Numeros en ordenados despues de quicksort");
            Imprimir(NumerosB);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Tercer arrgelo de numeros en desorden");
            Imprimir(NumerosC);
            QuickSort(NumerosC);
            Console.WriteLine("Numeros en ordenados despues de quicksort");
            Imprimir(NumerosC);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Cuarto arrgelo de numeros en desorden");
            Imprimir(NumerosD);
            QuickSort(NumerosD);
            Console.WriteLine("Numeros en ordenados despues de quicksort");
            Imprimir(NumerosD);
            Console.ReadKey();
            Console.Clear();
        }
        static void Imprimir(double[] arreglo)//metodo con el que imprimo los arreglos
        {
            foreach (double i in arreglo)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void QuickSort(double[] a)//metodo con el que inicialmente comenzamos a ordenar los numeros
        {
            QuickSort(a, 0, a.Length - 1);
        }

        static void QuickSort(double[] a, int start, int end)//metodo recrsivo con el que vamos ordenando los numeros
        {
            if (start >= end)
            {
                return;
            }

            double num = a[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && a[j] > num)
                {
                    j--;
                }

                a[i] = a[j];

                while (i < j && a[i] < num)
                {
                    i++;
                }

                a[j] = a[i];
            }

            a[i] = num;
            QuickSort(a, start, i - 1);
            QuickSort(a, i + 1, end);
        }
    }
}
