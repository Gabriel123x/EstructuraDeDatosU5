using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5.AcevedoEnsisoPedroGabriel
{
    class OrdenamientoBurbuja
    {
        int temp;//variable entera temporal en donde se guarda el entero que cumpla con la condicion para cambiarlo posteriormente de lugar
        private int[] vector;
        public void Cargar()
        {
            string linea;//este codigo esta hecho para que uno ingrese los numeros a vector que desee ordenar
            int cant;
            Console.WriteLine("Metodo de Burbuja");
            Console.Write("Cuantos elementos tiene el vector? ");
            linea = Console.ReadLine();
            cant = int.Parse(linea);
            Console.WriteLine("Solo se pueden introducir 0, 1, 2 ");
            vector = new int[cant];//se le da el tamaño que introducimos al vector
            for (int f = 0; f < vector.Length; f++)//con este ciclo pretendemos agregar cada elemento al vector
            {
                bool chequeo = true;
                Console.Write("Ingrese elemento " + (f + 1) + ": ");
                linea = Console.ReadLine();
                foreach (char i in linea)//en este ciclo comprobamos si algun numero introducido no es un 0, 1, 2
                {
                    if(i != '0' && i != '1' && i != '2')
                    {
                        chequeo = false;//si resulta no cumplir con eso entonces es un numero no valido
                    }
                }
                if (chequeo == true)//si el numero introducido fue valido entonces lo agregamos al arreglo
                {
                    vector[f] = int.Parse(linea);
                }
                else//de no ser asi el ciclo continua hasta que se introduscan los numeros necesarios para llenar el arreglo
                {
                    Console.WriteLine("Caracter introducido no valido");
                    f--;//le restamos uno a f para que el ciclo for continue
                }
            }
        }
        public void Burbuja()//aqui tenemos el metodo de ordenamienot burbuja
        {
            for (int i = 0; i < vector.Length; i++)//utilizamos dos ciclos for anidados donde checamos cada uno de los elementos del arreglo
            {
                for (int j = 0; j < vector.Length - 1; j++)//cada elemento del arreglo se compara con todos los otros elementos del arreglo
                {
                    if (vector[i] < vector[j])//si el elemento actual i es menor al elemento con el que se compara j se cambian de lugar
                    {
                        temp = vector[i];//la manera en que los cambiamos de lugar es que primero guardamos esa variable temporalmente aqui
                        vector[i] = vector[j];//ese mismo elemento se guarda en la posicion que resulto ser mayor
                        vector[j] = temp;//en donde este el elemento mayor se le guarda el elemento menor que se guardo en la variable temporal                       
                    }
                }
            }
        }
        public void Imprimir()//metodo que usamos para imprimir nuestro vector
        {
            Console.WriteLine("Imprimimos arreglo ordenado");
            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write(vector[f] + "  ");
            }
        }
    }
}
