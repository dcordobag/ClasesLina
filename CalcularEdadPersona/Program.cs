
namespace CalcularEdadPersona
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            /***
             ESCRIBA UN PROGRAMA QUE DADO EL AÑO DE NACIMIENTO DE UNA PERSONA, 
            CALCULE CUANTOS AÑOS TIENE LA PERSONA, TENIENDO EN CUENTA, QUE EL AÑO
            ACTUAL ES 2022
             */
            /* CONDICIONES:
             *  SI LA PERSONA, TIENE MENOS DE 18 AÑOS, EL SISTEMA DEBE INDICARLE QUE
             *  NO DEBE PAGAR SERVICIO MILITAR
             *  
             *  SI LA PERSONA ES MAYOR O IGUAL A 18 AÑOS, EL SISTEMA DEBE DECIRLE QUE
             *  DEBE PRESTAR SERVICIO MILITAR
             * ***/

            int anioNacimiento;
            int edad;

            Console.WriteLine("Ingrese el año de nacimiento:");
            anioNacimiento = int.Parse(Console.ReadLine());

            edad = 2022- anioNacimiento;

            //Console.WriteLine($"Su edad es: {edad}");

            if (edad < 18)
            {
                Console.WriteLine("No debe pagar servicio militar");
            }else
            {
                Console.WriteLine("Debe pagar servicio militar");
            }

            Console.ReadKey();
        }
    }
}
