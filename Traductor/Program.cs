
namespace Traductor
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class Program
    {
        /**
         * ESCRIBA UN PROGRAMA, QUE HAGA LA TRADUCCIÓN DE UNA PALABRA, A UN IDIOMA DETERMINADO POR EL USUARIO
         * 
         * SU PROGRAMA, DEBE PERMITIR LOS SIGUIENTES LENGUAJES
         * 
         * ESPAÑOL
         * INGRES
         * MANDARÍN
         * RUSO
         * DESPLIEGUE UNA PANTALLA PRINCIPAL, DONDE EL USUARIO DEBERÁ SELECCIONAR A QUÉ IDIOMA QUIERE TRADUCIR SU PALABRA
         * **/
        static void Main(string[] args)
        {
            /***
             ENTRADA                        PROCESO                 SALIDA
              palabra                       traducir la             palabra traducida
               idioma                       palabra
             */
            SolicitarPalabraEIdioma();
            Console.ReadKey();
        }

        public static void SolicitarPalabraEIdioma()
        {
            string palabra;
            int idiomaSeleccionado;
            string palabraTraducida;
            Console.WriteLine("Ingrese la palabra a traducir:");
            palabra = Console.ReadLine();
            Console.WriteLine($"Seleccione el idioma al cual quiere traducir la palabra {palabra}");
            Console.WriteLine($"1. Español{Environment.NewLine}2. Ingles{Environment.NewLine}3. Mandarín{Environment.NewLine}4. Ruso");
            idiomaSeleccionado = int.Parse(Console.ReadLine());
            if (idiomaSeleccionado == 1)
            {
                palabraTraducida = TraducirAEspanol(palabra);
            }
            else if (idiomaSeleccionado == 2)
            {
                palabraTraducida = TraducirAIngles(palabra);
            }
            else if (idiomaSeleccionado == 3)
            {
                palabraTraducida = TraducirAMandarin(palabra);
            }
            else if (idiomaSeleccionado == 4)
            {
                palabraTraducida = TraducirARuso(palabra);
            }
            else
            {
                palabraTraducida = "Lo siento, no encuentro el idioma que seleccionaste!";
            }
            Console.WriteLine(palabraTraducida);
        }

        public static string TraducirAEspanol(string palabraATraducir)
        {
            return $"Palabra {palabraATraducir} traducida al Español";
        }
        public static string TraducirAIngles(string palabraATraducir)
        {
            return $"Palabra {palabraATraducir} traducida al Ingles";
        }
        public static string TraducirAMandarin(string palabraATraducir)
        {
            return $"Palabra {palabraATraducir} traducida al Mandarín";
        }
        public static string TraducirARuso(string palabraATraducir)
        {
            return $"Palabra {palabraATraducir} traducida al Ruso";
        }
    }
}
