using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EdadYNombre();
            Console.ReadKey();
        }

        static void EdadYNombre() {
            Console.WriteLine("Ingrese su nombre y edad separados por comas");
            string nombreYEdad = Console.ReadLine();
            Console.WriteLine($"Su nombre y edad son:{nombreYEdad}");

        }
    }
}
