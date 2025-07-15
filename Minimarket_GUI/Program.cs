using System;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;
using OfficeOpenXml;

namespace Minimarket_GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Establecer la licencia para EPPlus (versi�n 8+)
            // Si tu uso es personal (no comercial), usa esta l�nea:
            ExcelPackage.License.SetNonCommercialPersonal("AldeasPeru");

            // Si usas EPPlus como organizaci�n sin fines de lucro:
            // ExcelPackage.License.SetNonCommercialOrganization("Aldeas Infantiles SOS");

            // Si tienes una licencia comercial, usa esta l�nea en su lugar:
            // ExcelPackage.License.SetCommercial("CLAVE-DE-LICENCIA");

            // Configuraci�n de la app
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}
