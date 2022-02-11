
namespace EncontrarFamiliaridad
{
    using System;
    internal static class Program
    {
        static void Main(string[] args)
        {
            string parentescoConPadres;
            string parentescoConAndres;

            parentescoConPadres = LeerParentezco();
            parentescoConAndres = CalcularParentesco(parentescoConPadres);

            Console.WriteLine($"La persona es el/la {parentescoConAndres} de Andres");

            Console.ReadKey();
        }
        static string LeerParentezco()
        {
            Console.WriteLine("Ingrese su parentesco con los padres de Andres:");
            return Console.ReadLine();
        }

        static string CalcularParentesco(string parentezco)
        {
            if (parentezco.ToLowerInvariant() == "hermano" || parentezco.ToLowerInvariant() == "hermana")
            {
                return "tio/tia";
            }
            else if (parentezco.ToLowerInvariant() == "madre" || parentezco.ToLowerInvariant() == "padre")
            {
                return "Abuelo/abuela";
            }
            else if (parentezco.ToLowerInvariant() == "sobrino" || parentezco.ToLowerInvariant() == "sobrina")
            {
                return "primo/prima";
            }
            else if (parentezco.ToLowerInvariant() == "hijo" || parentezco.ToLowerInvariant() == "hija")
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
