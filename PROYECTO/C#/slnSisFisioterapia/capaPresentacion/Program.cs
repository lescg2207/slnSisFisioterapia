using capaNegocios;

namespace capaPresentacion
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            var pacientesDll = new PacienteBll();


            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(pacientesDll));

        }
    }
}