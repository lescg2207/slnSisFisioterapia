using capaNegocios;

namespace capaPresentacion
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMenu());

        }
    }
}