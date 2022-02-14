namespace Referencias
{
    public class Program
    {
        static void Main(string[] args)
        {
            MetodoNoEstatico();
        }

        public void MetodoNoEstatico()
        {

        }
        
        public void MetodoNoEstatico2()
        {
            MetodoNoEstatico();
            MetodoEstatico();
        }
        static public void MetodoEstatico()
        {
            MetodoNoEstatico();
        }
    }

    public class Referenciadora
    {
        public void LlamarMetodosDeClaseProgram()
        {
            Program program = new Program();
            program.MetodoNoEstatico();
            program.MetodoEstatico();

            Program.MetodoEstatico();
            Program.MetodoNoEstatico();
        }
    }
}
