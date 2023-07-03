using capaNegocios;

namespace capaPresentacion
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            string providerName= "SqlServer";
            string connectionString= "Server=localhost;Database=BDFisio;User Id=sa;Password=les123;TrustServerCertificate=true;";
            ApplicationConfiguration.Initialize();
            Application.Run(new FormGestor());

        }
    }
}