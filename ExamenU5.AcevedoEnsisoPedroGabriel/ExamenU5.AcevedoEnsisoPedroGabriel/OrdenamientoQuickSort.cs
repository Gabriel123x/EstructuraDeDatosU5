using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5.AcevedoEnsisoPedroGabriel
{
    class OrdenamientoQuickSort
    {
        private char[] vector;
        public void Cargar()
        {
            Console.WriteLine("Metodo de QuickSort");//primero introducimos la frase como un string
            string frase = "lorem ipsum dolor sit amet, consectetur adipiscing elit. fusce varius, augue vitae tincidunt viverra, sem felis bibendum nisl, id cursus diam leo sit amet urna. duis ac massa est.";
            vector = new char[frase.Length];//le damos el tamaño de la cantidad de caracteres que tenga la frase al vector
            int conteo = 0;
            foreach(char i in frase)//aqui en este ciclo agregamos cada uno de los caracteres en la frase en el vector de caracteres
            {
                vector[conteo] = i;//lo ponemos en la posicion de conteo que empezo en cero
                conteo++;
            }
        }
        public void Imprimir()//metodo que usamos para imprimir nuestro vector
        {
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
        public void QuickSort()//metodo que manda a llamar el metodo recursivo quicksort
        {
            QuickSort(vector, 0, vector.Length - 1);
        }
        public void QuickSort(char[] vector, int primero, int ultimo)//aqui tenemos el metodo quicksort con el que ordenamos nuestro arreglo de caracteres
        {
            int i, j, central;
            double pivote;
            central = (primero + ultimo) / 2;
            pivote = Convert.ToInt32(vector[central]);//el metodo es como cualquier otro quick sort solo que tuvo que ser modificado para ordenar caracteres como aqui
            i = primero;
            j = ultimo;
            do
            {
                while (Convert.ToInt32(vector[i]) < pivote) i++;//cada ves que hacemos comparaciones con el pivote nos aseguramos de convertir el caracter en un numero para poder compararlo
                while (Convert.ToInt32(vector[j]) > pivote) j--;
                if (i <= j)
                {
                    char temp;//aqui tuvimos que modificar la variable temp de int a char
                    temp = vector[i];
                    vector[i] = vector[j];
                    vector[j] = temp;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (primero < j)
            {
                QuickSort(vector, primero, j);
            }
            if (i < ultimo)
            {
                QuickSort(vector, i, ultimo);
            }
        }//el motivo por el que esto funciona es por que resulta las letras de abcedario esta ya ordenadas en el codigo ASCII en orden ascendente entonces cuando transformamos un caracter a int32 este toma su valor en codigo ASCII y asi es como pudimos ordenar la frase
    }
}
