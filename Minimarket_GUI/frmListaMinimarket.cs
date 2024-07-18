using Minimarket_BE;
using Minimarket_BL;
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
    public partial class frmListaMinimarket : Form
    {
        MinimarketBL objminimarketBL = new MinimarketBL();
        DataView dtv;

        public frmListaMinimarket()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            // Construimos el dataview en base al datatable devuelto por el metodo ListarCategoria
            dtv = new DataView(objminimarketBL.ListarMinimarketActivos());
            // Y se filtra el dataview segun la cadena strFiltro recibido como parametro
            dtv.RowFilter = "Nombre like  '%" + strFiltro + "%'";
            // Se enlaza el datagrid al dataview ya filtrado
            dtgDatosMinimarket.DataSource = dtv;
            // Mostramos la cantidad de filas filtradas
            lblRegistros.Text = dtgDatosMinimarket.Rows.Count.ToString();

            // Verificar si no hay minimarkets activos y deshabilitar botones si es necesario
            if (dtgDatosMinimarket.Rows.Count == 0)
            {
                btnInhabilitar.Enabled = false;

                MessageBox.Show("No hay minimarkets activos. Debe crear uno nuevo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Opcionalmente, puedes abrir el formulario de creación de minimarkets aquí
                btnInsertar_Click(null, null);
            }
            else
            {
                btnInhabilitar.Enabled = true;

            }
        }

        private void dtgDatosMinimarket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListaMinimarket_Load(object sender, EventArgs e)
        {
            try
            {
                // Configuramos el datagrid para que no se generen columnas automaticamente
                dtgDatosMinimarket.AutoGenerateColumns = false;
                // Invocamos al metodo para cargar los datos              
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            // Implementar la lógica de actualización aquí
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            frmInsertarMinimarket frmGenerar = new frmInsertarMinimarket();
            frmGenerar.ShowDialog();
            // Recargar datos después de insertar
            CargarDatos(txtFiltro.Text.Trim());
        }

        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                // Muestra un cuadro de diálogo para confirmar la acción
                DialogResult vrpta = MessageBox.Show("¿Seguro de eliminar el Minimarket?", "Confirmar", MessageBoxButtons.YesNo);

                if (vrpta == DialogResult.Yes)
                {
                    // Obtenemos el código que se va a eliminar y lo convertimos a Int16
                    Int16 codigo = Convert.ToInt16(dtgDatosMinimarket.CurrentRow.Cells[0].Value);

                    // Creamos una instancia de MinimarketBE con el código
                    MinimarketBE minimarket = new MinimarketBE
                    {
                        Id_Empresa = codigo
                    };

                    // Llama al método del negocio para inhabilitar el minimarket
                    bool result = objminimarketBL.InhabilitarMinimarket(minimarket);

                    if (result)
                    {
                        // Recarga los datos en la grilla después de la inhabilitación
                        CargarDatos(txtFiltro.Text.Trim());
                    }
                    else
                    {
                        MessageBox.Show("El Minimarket no se puede eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Muestra el error en un cuadro de mensaje
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
           
            frmInsertarMinimarket listausu = new frmInsertarMinimarket();
         
            listausu.Show();
        }
    }
}