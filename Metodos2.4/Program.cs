using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos2._4
{
    internal class Program
    {
        /*
         * CREAR UN MÉTODO NO ESTÁTICO QUE LEA UN NÚMERO Y LO DEVUELVA AL MAIN
         * CREAR OTRO MÉTODO QUE QUE LEA UN NÚMERO Y LO RETORNE AL MAIN
         * CREAR OTRO MÉTODO QUE RECIBA LOS DOS NÚMEROS Y LOS MULTIPLIQUE
         * CREAR OTRO MÉTODO QUE SE LLAME DESDE EL MÉTODO ANTERIOR, RECIBA EL RESULTADO DE LA MULTIPLICACION 
           LO DIVIDA POR 100 E IMPRIMA EL RESULTADO DE LA MULTIPLICACIÓN QUE LE LLEGÓ Y EL RESULTADO DE LA DIVISIÓN
         * ***/
        static void Main(string[] args)
        {
            Program referencia = new Program();
            int var1 = referencia.leaNumero1();
            int var2 = leanumero2();
            recibirNumeros(var1, var2);
        }

        public int leaNumero1()
        {
            Console.WriteLine("Escriba numero uno");
            int Numero1 = int.Parse(Console.ReadLine());
            return Numero1;
        }

        static int leanumero2()
        {
            Console.WriteLine("Escriba numero dos");
            int Numero2 = int.Parse(Console.ReadLine());
            return Numero2;
        }

        static void recibirNumeros(int num1,int num2)
        {
      
           int resultado = num1 * num2;
           recibirResultado(resultado);
        }

        static void recibirResultado(int parametro)
        {
            int division = parametro / 100;
            Console.WriteLine($"Multipliucacion que llegó: {parametro} y división: {division}");
        }
    }
}
