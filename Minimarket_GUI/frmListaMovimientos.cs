using Minimarket_BL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;
using Minimarket_BE;

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
                // Obtenemos la ruta de la plantilla
                string rutaarchivo = @"C:\Excel\Plantilla_Movimiento.xlsx";

                DataTable dtRemision = new DataTable();

                // Obtener los datos actuales del DataGridView
                if (dtgRemision.DataSource is DataView dataView)
                {
                    dtRemision = dataView.ToTable();
                }
                else if (dtgRemision.DataSource is DataTable dataTable)
                {
                    dtRemision = dataTable;
                }
                else
                {
                    MessageBox.Show("No se encontraron datos para generar el reporte.");
                    return;
                }

                // Obtenemos la selección del ComboBox
                string periodoSeleccionado = cboTiempoPeriodo.SelectedItem.ToString();

                // Definimos la fila de inicio del reporte
                int fila1 = 7;

                // Creamos un objeto para el excel que se ha levantado 
                using (var pack = new ExcelPackage(new FileInfo(rutaarchivo)))
                {
                    // Indicamos que se va a trabajar en la HOJA1
                    ExcelWorksheet ws = pack.Workbook.Worksheets["Hoja1"];

                    ws.Cells["F4"].Value = $"{periodoSeleccionado}";

                    ws.Cells["C4"].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                    // Imprimimos en un bucle cada registro del dtRemision
                    foreach (DataRow drMovimiento in dtRemision.Rows)
                    {
                        ws.Cells[fila1, 2].Value = drMovimiento["Nom_Producto"].ToString();
                        ws.Cells[fila1, 3].Value = drMovimiento["Movimiento_Tienda"].ToString();
                        ws.Cells[fila1, 4].Value = drMovimiento["Des_UM"].ToString();
                        ws.Cells[fila1, 5].Value = drMovimiento["Fec_Registro"].ToString();
                        ws.Cells[fila1, 6].Value = drMovimiento["Usu_Registro"].ToString();

                        // Se incrementa +1 para imprimir la siguiente fila
                        fila1 += 1;
                    }

                    // Modificamos el ancho de las columnas
                    ws.Column(1).Width = 30; // Columna A..
                    ws.Column(2).Width = 30; // Columna B...
                    ws.Column(3).Width = 30;
                    ws.Column(4).Width = 40;
                    ws.Column(5).Width = 30;

                    // Definimos un nombre para el reporte 
                    string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string filename = $"ReporteMovimientoAlmacen_{clsCredenciales.Login_Usuario}-{timestamp}.xlsx";

                    // Creamos el archivo (con el nombre de arriba en blanco)
                    using (var fs = new FileStream($@"C:\PruebaExcel\{filename}", FileMode.Create))
                    {
                        pack.SaveAs(fs);
                    }

                    // Mandamos el mensaje al usuario
                    MessageBox.Show("El listado se ha generado satisfactoriamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void frmListaMovimientos_Load(object sender, EventArgs e)
        {
            try
            {
                // Añadir opciones al ComboBox
                cboTiempoPeriodo.Items.Add("--Seleccione--");
                cboTiempoPeriodo.Items.Add("Esta semana");
           
             

                // Establecer la opción predeterminada
                cboTiempoPeriodo.SelectedIndex = 0;

                // Asignar el evento SelectedIndexChanged al ComboBox
                cboTiempoPeriodo.SelectedIndexChanged += cboTiempoPeriodo_SelectedIndexChanged;

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

        private void cboTiempoPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTiempoPeriodo.SelectedIndex == 0)
            {
                // Si la selección es "--Seleccione--", cargar todos los datos
                dtgRemision.AutoGenerateColumns = false;
                CargarDatos("");
                return;
            }

            string seleccionTiempo = cboTiempoPeriodo.SelectedItem.ToString();
            DateTime startDate = DateTime.Now;
            DateTime endDate = DateTime.Now;

            switch (seleccionTiempo)
            {
                case "Esta semana":
                    startDate = DateTime.Now.AddDays(-(int)DateTime.Now.DayOfWeek);
                    endDate = startDate.AddDays(6).Date.AddHours(23).AddMinutes(59).AddSeconds(59);
                    break;
          
            }

            CargarDatosFiltrados(startDate, endDate);
        }

        private void CargarDatosFiltrados(DateTime startDate, DateTime endDate)
        {
            DataTable dtMovimiento = objMovimientoBL.ListarMovimiento();
            DataView dv = new DataView(dtMovimiento);
            dv.RowFilter = $"Fec_Registro >= #{startDate:yyyy/MM/dd}# AND Fec_Registro <= #{endDate:yyyy/MM/dd}#";
            dtgRemision.DataSource = dv;
            lblRegistros.Text = dv.Count.ToString();
        }
    }
}
