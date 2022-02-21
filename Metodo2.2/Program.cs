using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo2._2
{
    internal class Program
    {
        /**CREAR UN METODO QUE RECIBA EL NOMBRE DESDE EL MAIN LEA LA EDAD Y LOS IMPRIMA**/
        static void Main(string[] args)
        {
            metodo("David");
            Console.ReadKey();
        }
        
        static void metodo(string nombre)
        {
            Console.WriteLine("Ingrese su edad");
            string edad = Console.ReadLine();
            Console.WriteLine($"su nombre es: {nombre} y tienes: {edad}");
        }
    }
}
