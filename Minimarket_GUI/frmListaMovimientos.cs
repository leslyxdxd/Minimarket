using Minimarket_BL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using Microsoft.Extensions.FileProviders;

namespace Minimarket_GUI
{
    public partial class frmListaMovimientos : Form
    {
        MovimientoBL objMovimientoBL = new MovimientoBL();
        DataView dtv;

        public frmListaMovimientos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos la ruta de la plantilla
                String rutaarchivo = @"C:\Excel\Plantilla_Movimiento.xlsx";


                //Obtenemos la lista de proveedores 
                DataTable dtMovimiento = objMovimientoBL.ListarMovimiento();

                //definimos la fila de inicio del reporte
                Int16 fila1 = 7;

                //Cramos un objeto para el excel que se a levantado 
                using (var pack = new ExcelPackage(new FileInfo(rutaarchivo)))
                {
                    //Indicamos que se va a trabajr en la HOJA1
                    ExcelWorksheet ws = pack.Workbook.Worksheets["Hoja1"];

                    ws.Cells["C4"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    //Imprimimos en un bucle cada registro del dtpProveedores
                    foreach (DataRow drProveedor in dtMovimiento.Rows)
                    {

                        ws.Cells[fila1, 2].Value = drProveedor["Nom_Producto"].ToString();

                        ws.Cells[fila1, 3].Value = drProveedor["Movimiento_Tienda"].ToString();

                        ws.Cells[fila1, 4].Value = drProveedor["Des_UM"].ToString();

                        ws.Cells[fila1, 5].Value = drProveedor["Fec_Registro"].ToString();

                        ws.Cells[fila1, 6].Value = drProveedor["Usu_Registro"].ToString();

                        //Se incrementa +1 para imprimir la fila 6 y asi ira imprimiento fila por fila
                        fila1 += 1;
                    }

                    //Modificamos el ancho de las columnas
                    ws.Column(1).Width = 30;//Columna A..
                    ws.Column(2).Width = 30;//Columna B...
                    ws.Column(3).Width = 30;
                    ws.Column(4).Width = 40;
                    ws.Column(5).Width = 30;


                    //Definimos un nombre para el reporte 
                    String timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    String filename = "ReporteMovimientoAlmacen_" + clsCredenciales.Login_Usuario + "-"+ timestamp + ".xlsx";

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

        private void frmListaMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                dtgRemision.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void CargarDatos(string Nom_Producto)
        {
            dtv = new DataView(objMovimientoBL.ListarMovimiento());
            dtv.RowFilter = "Nom_Producto LIKE '%" + Nom_Producto + "%'";
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
    }
}
