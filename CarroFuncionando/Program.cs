
namespace CarroFuncionando
{
    using System;
    internal class Lina
    {
        /***
         LA AGENCIA DE CARROS DARRICARROS, LO HA CONTRATADO PARA QUE LE HAGA LAS PRUEBAS
        A SUS VEHÍCULOS ANTES DE UTILIZARLOS. PARA ELLO, USTED DEBE:

        -CREAR UN MÉTODO QUE PRUEBE LA FUNCIONALIDAD DE LAS LLANTAS (ESTÁTICO)
        -CREAR UN MÉTODO QUE PRUEBE LA FUNCIONALIDAD DE LOS FRENOS (PRIVADO)
        -CREAR UN MÉTODO QUE PRUEBE LA FUNCIONALIDAD DEL CLAXON (PITO DEL CARRO) (ESTÁTICO)
        -CREAR UN MÉTODO QUE PRUEBE LA FUNCIONALIDAD DE LOS VIDRIOS ELÉCTRICOS (INTERNO CON RETORNO)

        *UTILICE LA ACCESIBILIDAD INDICADA, Y EN CASO DE QUE EL MÉTODO SEA CON RETORNO, DEVOLVER EL RESULTADO DEL TEST
        * SI EL MÉTODO NO ES CON RETORNO, IMPRIMIR EN ÉL MISMO, EL RESULTADO DEL TEST
         */
        static void Main(string[] args)
        {
            Lina computador = new Lina();
            computador.FuncionalidadLlantas();
            FuncionalidadFrenos();
            computador.FuncionalidadClaxon();
            string estatico = FuncionalidadVidrios();
            Console.WriteLine(estatico);

            Console.ReadKey();
        }

        public void FuncionalidadLlantas()
        {
            Console.WriteLine("Las llantas están desgastadas");
        }

        private static void FuncionalidadFrenos()
        {
            Console.WriteLine("Los frenos están desgastados");
        }

        public void FuncionalidadClaxon()
        {
            Console.WriteLine("El claxon tiene buen sonido");
        }

        private static string FuncionalidadVidrios()
        {
            return "Los vidrios suben y bajan correctamente";
        }
    }
}
