
namespace ClasesLina
{
    using System;

    public class Program
    {
        static void Main(string[] args)
        {
            /**
             REALIZAR UN ALGORITMO QUE PERMITA INGRESAR EL NOMBRE DEL TRABAJADOR,
             LAS HORAS TRABAJADAS Y MUESTRE EL SALARIO A PAGAR
             TENIENDO EN CUENTA, QUE EL VALOR DE LA HORA ES DE $50.000 PESOS
             */

            string nombreTrabajador;
            int horasTrabajadas;
            decimal salario;

            Console.WriteLine("Ingrese Su nombre:");
            nombreTrabajador = Console.ReadLine();

            Console.WriteLine("Ingrese las horas trabajadas:");
            horasTrabajadas = int.Parse(Console.ReadLine());

            salario = horasTrabajadas * 50000;

            Console.WriteLine($"Señor {nombreTrabajador}, su salario es : " + salario.ToString("$#,##0"));

            Console.ReadKey();
        }
    }
}