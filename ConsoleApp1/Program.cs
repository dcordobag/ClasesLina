
namespace ClasesLina
{
    using System;

    public static class Program
    {
        /**
         REALIZAR UN ALGORITMO QUE PERMITA INGRESAR EL NOMBRE DEL TRABAJADOR,
         LAS HORAS TRABAJADAS Y MUESTRE EL SALARIO A PAGAR
         TENIENDO EN CUENTA, QUE EL VALOR DE LA HORA ES DE $50.000 PESOS
         */

        static void Main(string[] args)
        {
            string nombreTrabajador;
            int horasTrabajadas;
            decimal salario;
            const int valorHora = 50000;

            Console.WriteLine("Ingrese Su nombre:");
            nombreTrabajador = Console.ReadLine();

            Console.WriteLine("Ingrese las horas trabajadas:");
            horasTrabajadas = int.Parse(Console.ReadLine());

            salario = horasTrabajadas * valorHora;

            Console.WriteLine($"Señor {nombreTrabajador}, su salario es : " + salario.ToString("$#,##0"));

            Console.ReadKey();
        }
    }
}