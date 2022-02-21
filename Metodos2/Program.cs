using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2
{
    internal class Program
    {
        /**CREAR UN METODO QUE LEA EL NOMBRE Y LO IMPRIMA AHI MISMO
         * 
         * 
         * **/
        static void Main(string[] args)
        {
            Nombre();
            Console.ReadKey();
        }
            
        static void Nombre()
        {
            
            Console.WriteLine("Ingrese nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine($"su nombre es:{nombre}");

            
        }
    }
}
