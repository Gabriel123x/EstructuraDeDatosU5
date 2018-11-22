using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_1.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;//variable entera temporal en donde se guarda el entero que cumpla con la condicion para cambiarlo posteriormente de lugar
            int[] Burbuja = new int[10] { 3, 2, 6, 7, 10, 8, 9, 1, 4, 5 };//se declaran 10 numeros en desorden 
            Console.WriteLine("Imprimimos los elementos en desorden");
            foreach (int i in Burbuja)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            for(int i = 0; i < Burbuja.Length; i++)//utilizamos dos ciclos for anidados donde checamos cada uno de los elementos del arreglo
            {
                for(int j = 0; j < Burbuja.Length - 1; j++)//cada elemento del arreglo se compara con todos los otros elementos del arreglo
                {
                    if(Burbuja[i] < Burbuja[j])//si el elemento actual i es menor al elemento con el que se compara j se cambian de lugar
                    {
                        temp = Burbuja[i];//la manera en que los cambiamos de lugar es que primero guardamos esa variable temporalmente aqui
                        Burbuja[i] = Burbuja[j];//ese mismo elemento se guarda en la posicion que resulto ser mayor
                        Burbuja[j] = temp;//en donde este el elemento mayor se le guarda el elemento menor que se guardo en la variable temporal                       
                    }
                }
            }
            Console.WriteLine("Imprimimos los elementos en orden despues de usar el metodo de la burbuja");
            foreach (int i in Burbuja)//volvemos a imprimir todos los elementos para comprovar que estan ordenados
            {
                Console.Write(" " + i);
            }
            Console.ReadKey();
        }
    }
}
