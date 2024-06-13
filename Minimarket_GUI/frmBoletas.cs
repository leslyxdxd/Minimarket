using Minimarket_ADO;
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
    public partial class frmBoletas : Form
    {
        BoletaADO boletaADO = new BoletaADO();
        public string Codigo { get; set; }

        public frmBoletas()
        {
            InitializeComponent();
        }

        private void frmBoletas_Load(object sender, EventArgs e)
        {
            try
            {
                lblRegistros.Text = dtgDatos.Rows.Count.ToString();
                // Cargar los detalles de la boleta al cargar el formulario
                if (!string.IsNullOrEmpty(Codigo))
                {
                    CargarDetalleBoleta(Codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la boleta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void CargarDetalleBoleta(string codigoBoleta)
        {
            try
            {
                // Llamar al método ConsultarBoleta de la capa de acceso a datos para obtener los detalles
                DataTable dtDetallesBoleta = boletaADO.ConsultarBoleta(codigoBoleta);

                // Limpiar columnas existentes en el DataGridView
                dtgDatos.Columns.Clear();

                // Configurar el DataGridView para no autogenerar las columnas
                dtgDatos.AutoGenerateColumns = false;

                // Definir manualmente las columnas del DataGridView
                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nro_Boleta",
                    HeaderText = "Número de Boleta"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Nom_Producto",
                    HeaderText = "Nombre del Producto"
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
                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Des_UM",
                    HeaderText = "Unidad de Medida"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Marca",
                    HeaderText = "Marca"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Total",
                    HeaderText = "Total"
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Igv",
                    HeaderText = "IGV",
                    DefaultCellStyle = new DataGridViewCellStyle() { Format = "0.0" } // Formatear IGV
                });

                dtgDatos.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    DataPropertyName = "Subtotal",
                    HeaderText = "Subtotal",
                    DefaultCellStyle = new DataGridViewCellStyle() { Format = "0.0" } // Formatear Subtotal
                });

                // Asignar el DataTable como DataSource del DataGridView
                dtgDatos.DataSource = dtDetallesBoleta;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los detalles de la boleta: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
