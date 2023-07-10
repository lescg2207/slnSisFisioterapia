using capaNegocios;

namespace capaPresentacion
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            string gestor = "SqlServer";
            string cone = "Data Source=bdfisioterapia.database.windows.net;Initial Catalog=bdFisioterapia;User ID=sis;Password=proyFisio22;TrustServerCertificate=true;";

            ApplicationConfiguration.Initialize();
            Application.Run(new FrmListaCitaPac(gestor,cone));

        }
    }
}