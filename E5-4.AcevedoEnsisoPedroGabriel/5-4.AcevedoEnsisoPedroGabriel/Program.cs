using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4.AcevedoEnsisoPedroGabriel
{
    class Program
    {
        static void Main(string[] args)//en este main simplemente creamos un objeto PruebaOrdenamiento y corremos sus 3 metodos
        {
            PruebaOrdenamiento pv = new PruebaOrdenamiento();
            pv.Cargar();
            pv.Shell();
            pv.Imprimir();
        }
    }
}
