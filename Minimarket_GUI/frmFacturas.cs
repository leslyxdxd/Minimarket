using Minimarket_ADO; // Asegúrate de importar la referencia a tu capa de acceso a datos
using System;
using System.Data;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmFacturas : Form
    {
        FacturaADO facturaADO = new FacturaADO(); // Asegúrate de tener una instancia de tu clase ADO aquí

        public string Codigo { get; set; }

        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            try

            {
                lblRegistros.Text = dtgDatos.Rows.Count.ToString();
                // Cargar los datos de la factura al cargar el formulario
                if (!string.IsNullOrEmpty(Codigo))
                {
                    CargarDetalleFactura(Codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CargarDetalleFactura(string codigoFactura)
        {
            try
            {
                // Llamar al método ConsultarFactura de la capa de acceso a datos para obtener los detalles
                DataTable dtDetallesFactura = facturaADO.ConsultarFactura(codigoFactura);

                // Limpiar columnas existentes en el DataGridView
                dtgDatos.Columns.Clear();

                // Configurar el DataGridView para no autogenerar las columnas
                dtgDatos.AutoGenerateColumns = false;

                // Definir manualmente las columnas del DataGridView
                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Numero_Factura",
                    HeaderText = "Número de Factura"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nom_Producto",
                    HeaderText = "Nombre del Producto"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Marca",
                    HeaderText = "Marca"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Des_UM",
                    HeaderText = "Unidad de Medida"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Cantidad",
                    HeaderText = "Cantidad"
                });
                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Precio_Unitario",
                    HeaderText = "Precio Unitario",
                    DefaultCellStyle = new DataGridViewCellStyle { Format = "0.0" } // Formatear como 0.0
                });

                // Columna Total con formato de un decimal
                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Total",
                    HeaderText = "Total",
                    DefaultCellStyle = new DataGridViewCellStyle() { Format = "N2" }
                });

                // Columna IGV con formato de un decimal
                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "igv",
                    HeaderText = "IGV",
                    DefaultCellStyle = new DataGridViewCellStyle() { Format = "N2" }
                });

                // Columna Subtotal con formato de un decimal
                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "subTotal",
                    HeaderText = "Subtotal",
                    DefaultCellStyle = new DataGridViewCellStyle() { Format = "N2" }
                });

                // Asignar el DataTable como DataSource del DataGridView
                dtgDatos.DataSource = dtDetallesFactura;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la factura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
