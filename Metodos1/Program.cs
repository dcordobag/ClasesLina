using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nombre();
            Console.ReadKey();

        }

        static void Nombre()
        {
            string nombre;
            Console.WriteLine("Escriba su nombre");
            nombre = Console.ReadLine();
            Console.WriteLine($"Su nombre es:{nombre}");
        }
    }
}
