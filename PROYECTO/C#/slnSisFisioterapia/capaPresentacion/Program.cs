using capaNegocios;

namespace capaPresentacion
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            string providerName = "SqlServer";
            string connectionString = "Server=bdfisioterapia.database.windows.net;Database=bdFisioterapia;User Id=sis;Password=proyFisio22;TrustServerCertificate=true;";
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmLogin(providerName, connectionString));
        }
    }
}