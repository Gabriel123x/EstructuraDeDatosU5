using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU5.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)//en esta clase esta los ejercicios del examen
        {
            bool activo = true;
            string seleccionador;
            while (activo == true)
            {
                try
                {
                    Console.WriteLine("Examen unidad 5 de Acevedo Ensiso Pedro Gabriel");
                    Console.WriteLine("Seleccione el ejercicio a revisar");
                    Console.WriteLine("1) Problema 1");
                    Console.WriteLine("2) Problema 2");
                    Console.WriteLine("3) Problema 3");
                    Console.WriteLine("4) Problema 4");
                    Console.WriteLine("5) Salir del programa");
                    seleccionador = Console.ReadLine();//aqui se selecciona el problema se introduce un numero del 1 al 5
                    Console.Clear();
                    switch(seleccionador)
                    {
                        case "1"://problema 1
                            OrdenamientoBurbuja prueba1 = new OrdenamientoBurbuja();
                            prueba1.Cargar();
                            prueba1.Burbuja();
                            prueba1.Imprimir();
                            break;
                        case "2"://problema 2
                            OrdenamientoRadix prueba2 = new OrdenamientoRadix();
                            prueba2.Cargar();
                            Console.WriteLine("Imprimimos numeros generados aleatoriamente");
                            prueba2.Imprimir();
                            Console.WriteLine();
                            prueba2.Radix();
                            Console.WriteLine("Imprimimos numeros ordenados por metodo radix");
                            prueba2.Imprimir();
                            break;
                        case "3"://problema 3
                            OrdenamienoShell prueba3 = new OrdenamienoShell();
                            prueba3.Cargar();
                            prueba3.Shell();
                            prueba3.Imprimir();
                            break;
                        case "4"://problema 4
                            OrdenamientoQuickSort prueba4 = new OrdenamientoQuickSort();
                            prueba4.Cargar();
                            Console.WriteLine("Imprimimos frase desordenada");
                            prueba4.Imprimir();
                            prueba4.QuickSort();
                            Console.WriteLine();
                            Console.WriteLine("Imprimimos frase ordenada");
                            prueba4.Imprimir();
                            break;
                        case "5"://esta opcion es con la que cerramos el programa
                            activo = false;
                            Console.WriteLine("fin del programa");
                            break;
                        default://por si se introduce un caracter no valido
                            Console.WriteLine("Caracter no valido solo se aceptan numeros del 1 al 5");
                            break;
                    }

                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
                finally
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
