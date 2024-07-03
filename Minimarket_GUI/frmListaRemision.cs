using Minimarket_BE;
using Minimarket_BL;
using OfficeOpenXml;
using System;
using System.Data;
using System.Drawing;
using System.IO;
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
                if (dtgRemision.CurrentRow != null)
                {
                    DateTime fechaRegistro = Convert.ToDateTime(dtgRemision.CurrentRow.Cells["Fec_Registro"].Value);

                    if ((DateTime.Now - fechaRegistro).TotalDays <= 7)
                    {
                        frmActualizarRemision Remision = new frmActualizarRemision();
                        Remision.Id_Remision = dtgRemision.CurrentRow.Cells[0].Value.ToString();
                        Remision.ShowDialog();

                        dtv = new DataView(objRemisionBL.ListarRemision());
                        CargarDatos(txtFiltro.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("No se puede actualizar una guía de remisión con más de una semana de antigüedad.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una guía de remisión para actualizar.", "Selección necesaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
                String rutaarchivo = @"C:\Excel\Plantilla_ReporteGuia.xlsx";
                DataTable dtRemision = objRemisionBL.ListarRemision();
                Int16 fila1 = 8;

                using (var pack = new ExcelPackage(new FileInfo(rutaarchivo)))
                {
                    ExcelWorksheet ws = pack.Workbook.Worksheets["Hoja1"];
                    ws.Cells["C3"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    foreach (DataRow drRemisionG in dtRemision.Rows)
                    {
                        ws.Cells[fila1, 2].Value = drRemisionG["Num_Guia"].ToString();
                        ws.Cells[fila1, 3].Value = drRemisionG["Nom_Proveedor"].ToString();
                        ws.Cells[fila1, 4].Value = drRemisionG["RUC"].ToString();
                        ws.Cells[fila1, 5].Value = drRemisionG["Nom_Producto"].ToString();
                        ws.Cells[fila1, 6].Value = drRemisionG["Cantidad"].ToString() + "---" + drRemisionG["Des_UM_Producto"].ToString();
                        ws.Cells[fila1, 7].Value = drRemisionG["Punto_Partida"].ToString();
                        ws.Cells[fila1, 8].Value = drRemisionG["Punto_Llegada"].ToString();
                        ws.Cells[fila1, 9].Value = drRemisionG["Empresa_Transporte"].ToString() + "---" + drRemisionG["Placa_Trasporte"].ToString();
                        ws.Cells[fila1, 10].Value = drRemisionG["FechaIni"].ToString();
                        ws.Cells[fila1, 11].Value = drRemisionG["FechaFin"].ToString();
                        ws.Cells[fila1, 12].Value = drRemisionG["Usu_Registro"].ToString();
                        fila1 += 1;
                    }

                    ws.Column(1).Width = 23;
                    ws.Column(2).Width = 25;
                    ws.Column(3).Width = 21;
                    ws.Column(4).Width = 23;
                    ws.Column(5).Width = 23;
                    ws.Column(6).Width = 25;
                    ws.Column(7).Width = 30;
                    ws.Column(8).Width = 32;
                    ws.Column(9).Width = 43;
                    ws.Column(10).Width = 29;
                    ws.Column(11).Width = 29;
                    ws.Column(12).Width = 29;

                    String timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    String filename = "Reporte_GuiasRemision_" + clsCredenciales.Login_Usuario + "_" + timestamp + ".xlsx";

                    FileStream fs = new FileStream(@"C:\PruebaExcel\" + filename, FileMode.Create);
                    pack.SaveAs(fs);
                    pack.Dispose();
                    fs.Dispose();
                    MessageBox.Show("El listado se ha generado satisfactoriamente ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        // Método para manejar el evento CellDoubleClick en el DataGridView
        private void dtgRemision_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DateTime fechaRegistro = Convert.ToDateTime(dtgRemision.Rows[e.RowIndex].Cells["Fec_Registro"].Value);

                    if ((DateTime.Now - fechaRegistro).TotalDays <= 7)
                    {
                        frmActualizarRemision Remision = new frmActualizarRemision();
                        Remision.Id_Remision = dtgRemision.Rows[e.RowIndex].Cells[0].Value.ToString();
                        Remision.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No se puede consultar una guía de remisión con más de una semana de antigüedad.", "Restricción", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
