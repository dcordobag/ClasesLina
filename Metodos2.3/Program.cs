using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2._3
{
    internal class Program
    {
        /**
         * CREAR UN MÉTODO QUE LEA UN NOMBRE Y LO MANDE AL MAIN
         * CREAR OTRO MÉTODO QUE RECIBA EL NOMBRE DEVUELVO EN EL ANTERIOR Y LO IMPRIMA SI ES IGUAL A DAVID, 
         * SI NO, IMPRIMA NO COINCIDE
         * **/
        static void Main(string[] args)
        {
           string nombre = leerNombre();
           recibirNombre(nombre);
           Console.ReadKey();
        }

        static string leerNombre()
        {
            Console.WriteLine("Escriba su nombre");
            string Nombre= Console.ReadLine();
            return Nombre;
        }

        static void recibirNombre(string nombreRecibido)
        {
            if (nombreRecibido == "david")
            {
                Console.WriteLine(nombreRecibido);
            }
            else
            {
                Console.WriteLine("No coincide");
            }
        }
    }
}
