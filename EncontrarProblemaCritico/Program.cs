namespace EncontrarProblemaCritico
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            /***
             ESCRIBA UN PROGRAMA, QUE DADO UN COLOR PARA EL PROBLEMA, DEFINA SI EL PROBLEMA ES 
            CRÍTICO, MEDIO O BAJO
            TENIENDO EN CUENTA QUE
             */
            /*
             * ROJO INDICA CRÍTICO
             * NARANJA INDICA MEDIO
             * VERDE INDICA BAJO
             * 
             * CONSIDERACIONES: SE DEBE UTILIZAR UN MÉTODO QUE RECIBA EL COLOR Y 
             * DEVUELVA LA CRITICALIDAD DE ACUERDO CON LAS INDICACIONES ANTERIORES
             * ***/

            string color;
            string criticalidad;
            Console.WriteLine("Escriba el color:");
            color = Console.ReadLine();

            criticalidad = CalcularCriticalidad(color);
            Console.WriteLine($"El problema es: {criticalidad}");


            Console.ReadKey();
        }

        static string CalcularCriticalidad(string color)
        {
            if (color.ToLowerInvariant() == "rojo")
            {
                return "Crítico";
            }
            else if (color.ToLowerInvariant() == "naranja")
            {
                return "Medio";
            }
            else if (color.ToLowerInvariant() == "verde")
            {
                return "Bajo";
            }
            else
            {
                return "Color no válido";
            }
        }
    }
}
