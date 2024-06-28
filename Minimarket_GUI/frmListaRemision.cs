using Minimarket_BE;
using Minimarket_BL;
using OfficeOpenXml;
using ProyVentas_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmListaRemision : Form
    {

        RemisionBL objRemisionBL = new RemisionBL();
        DataView dtv;

        public frmListaRemision()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                frmGenerarRemision objGenerarRemision = new frmGenerarRemision();
                objGenerarRemision.ShowDialog();

                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void frmListaRemision_Load(object sender, EventArgs e)
        {
            try
            {
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                dtgRemision.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }



        private void CargarDatos(String Nom_Proveedor)
        {
            dtv = new DataView(objRemisionBL.ListarRemision());
            dtv.RowFilter = "Nom_Proveedor LIKE '%" + Nom_Proveedor + "%'";
            dtgRemision.DataSource = dtv;
            lblRegistros.Text = dtgRemision.Rows.Count.ToString();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                frmActualizarRemision Remision = new frmActualizarRemision();
                //Se toma el valor de la columna cero de la fila seleccionada 
                //en el datagriv
                Remision.Id_Remision = dtgRemision.CurrentRow.Cells[0].Value.ToString();
                Remision.ShowDialog();
                //Al retornar, resfrescamos la vista y cargamos los datos para ver los cambios 
                //del proveedor actualizado 
                dtv = new DataView(objRemisionBL.ListarRemision());
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos la ruta de la plantilla
                String rutaarchivo = @"C:\Excel\Plantilla_ReporteGuia.xlsx";


                //Obtenemos la lista de proveedores 
                DataTable dtRemision = objRemisionBL.ListarRemision();

                //definimos la fila de inicio del reporte
                Int16 fila1 = 8;

                //Cramos un objeto para el excel que se a levantado 
                using (var pack = new ExcelPackage(new FileInfo(rutaarchivo)))
                {
                    //Indicamos que se va a trabajr en la HOJA1
                    ExcelWorksheet ws = pack.Workbook.Worksheets["Hoja1"];

                    ws.Cells["C3"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    //Imprimimos en un bucle cada registro del dtpProveedores
                    foreach (DataRow drRemisionG in dtRemision.Rows)
                    {

                        ws.Cells[fila1, 2].Value = drRemisionG["Num_Guia"].ToString();

                        ws.Cells[fila1, 3].Value = drRemisionG["Nom_Proveedor"].ToString();

                        ws.Cells[fila1, 4].Value = drRemisionG["RUC"].ToString();

                        ws.Cells[fila1, 5].Value = drRemisionG["Nom_Producto"].ToString();

                        ws.Cells[fila1, 6].Value = drRemisionG["Cantidad"].ToString() + "---"  + drRemisionG["Des_UM_Producto"].ToString(); 

                      
                        ws.Cells[fila1, 7].Value = drRemisionG["Punto_Partida"].ToString();
                        ws.Cells[fila1, 8].Value = drRemisionG["Punto_Llegada"].ToString();


                        ws.Cells[fila1, 9].Value = drRemisionG["Empresa_Transporte"].ToString() + "---" + drRemisionG["Placa_Trasporte"].ToString();

                        ws.Cells[fila1, 10].Value = drRemisionG["FechaIni"].ToString();
                        ws.Cells[fila1, 11].Value = drRemisionG["FechaFin"].ToString();

                        ws.Cells[fila1, 12].Value = drRemisionG["Usu_Registro"].ToString();

                        //Se incrementa +1 para imprimir la fila 6 y asi ira imprimiento fila por fila
                        fila1 += 1;
                    }

                    //Modificamos el ancho de las columnas
                    ws.Column(1).Width = 23;//Columna A..
                    ws.Column(2).Width = 25;//Columna B...
                    ws.Column(3).Width = 21;
                    ws.Column(4).Width = 23;
                    ws.Column(5).Width = 23;
                    ws.Column(6).Width = 25;
                    ws.Column(7).Width = 30;//Columna A..
                    ws.Column(8).Width = 32;//Columna B...
                    ws.Column(9).Width = 43;
                    ws.Column(10).Width = 29;
                    ws.Column(11).Width = 29;
                    ws.Column(12).Width = 29;

                    //Definimos un nombre para el reporte 
                    String timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    String filename = "Reporte_GuiasRemision_" + clsCredenciales.Login_Usuario + "_" + timestamp + ".xlsx";

                    //Creamos el archivo (con el nombre de arriba en blanco)
                    FileStream fs = new FileStream(@"C:\PruebaExcel\" + filename, FileMode.Create);
                    pack.SaveAs(fs);

                    //Elinamos las instancias 
                    pack.Dispose();
                    fs.Dispose();//se destruye para que evite siguiendo en memoria

                    //Mandamos el mensajeal usuario..
                    MessageBox.Show("El listado se ha generado satisfactoriamente ");

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}
