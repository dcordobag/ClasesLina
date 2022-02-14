
namespace AccesibilidadVecino
{
    using Accesibilidades;
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.VisitarVecinos();
        }

        public void VisitarVecinos()
        {
            Casa vecinos = new Casa();
            vecinos.Ventana();
        }


    }

    public class VecinoHeredero : Casa
    {
        public void HeredarDinero()
        {
            DineroDeMama();
        }
    }
}
