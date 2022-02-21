using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2._1
{
    internal class Program
    {
        /**CREAR UN METODO QUE RECIBA EL NOMBRE DESDE EL MAIN Y LO IMPRIMA
         * 
         * **/
        static void Main(string[] args)
        {
            string NombreIngresado = "Lina";
            nombre(NombreIngresado);
            Console.ReadKey();
        }

        static void nombre(string nombreParametro)
        {
            
            Console.WriteLine($"su nombre es:{nombreParametro}");
 

        }
    }
}
