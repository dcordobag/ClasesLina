using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Edad();
            Console.ReadKey();
        }

        static void Edad()
        {
            Console.WriteLine("Escriba edad");
            string edad = Console.ReadLine();
            Console.WriteLine($"Su edad es:{edad}");
        }
    }
}
