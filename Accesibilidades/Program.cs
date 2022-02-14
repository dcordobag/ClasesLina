namespace Accesibilidades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    public class Casa
    {
        static void Main(string[] args)
        {
            Casa casa = new Casa();
            casa.Habitantes();
        }

        private void Habitantes()
        {
            Ventana();
            Habitacion();
            Nevera();
            DineroDeMama();
        }

        public void Ventana()
        {

        }
        private void Habitacion()
        {

        }
        internal void Nevera()
        {

        }
        protected void DineroDeMama()
        {

        }
    }

    public class Habitante
    {
        public void PermisosHabitantes()
        {
            Casa hogar = new Casa();
            hogar.Ventana();
            hogar.Nevera();
        }
    }
    public class Hijo : Casa
    {
        public void PeticionHijo()
        {
            DineroDeMama();
            Ventana();
            Nevera();
        }
    }
}

namespace Prueba
{
    using Accesibilidades;
    public class Pruebas
    {
        public void Test()
        {
            Casa hogar = new Casa();
            hogar.Nevera();
        }
    }
}
