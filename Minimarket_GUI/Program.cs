using OfficeOpenXml;

namespace Minimarket_GUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Establecer el contexto de la licencia para EPPlus
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // O LicenseContext.Commercial según tu licencia

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}
