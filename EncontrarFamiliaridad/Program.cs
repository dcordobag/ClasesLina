
namespace EncontrarFamiliaridad
{
    using System;
    internal class Program
    {
        static void Main(string[] args)
        {
            string parentescoConPadres;
            string parentescoConAndres;

            parentescoConPadres = LeerParentezco();
            parentescoConAndres = calcularParentesco(parentescoConPadres);
            
            Console.WriteLine($"La persona es el/la:{parentescoConAndres} de Andres");

            Console.ReadKey();
        }
        static string LeerParentezco()
        {
            Console.WriteLine("Ingrese su parentesco con los padres de Andres:");
            return Console.ReadLine();
        }

        static string calcularParentesco(string familiaridad)
        {
            if (familiaridad.ToLowerInvariant() == "hermano" || familiaridad.ToLowerInvariant() == "hermana")
            {
                return "tio/tia";
            }

            else if (familiaridad.ToLowerInvariant() == "madre" || familiaridad.ToLowerInvariant() == "padre")
            {
                return "Abuelo/abuela";
            }

            else if (familiaridad.ToLowerInvariant() == "sobrino" || familiaridad.ToLowerInvariant() == "sobrina")
            {
                return "primo/prima";
            }

            else if (familiaridad.ToLowerInvariant() == "hijo" || familiaridad.ToLowerInvariant() == "hija")
            {
                return "hermano/hermana";
            }

            else
            {
                return "El parentesco no es valido";
            }

        }

    }
}
