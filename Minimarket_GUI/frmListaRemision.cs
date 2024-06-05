using Minimarket_BE;
using Minimarket_BL;
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
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();
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
                dtgRemision.AutoGenerateColumns = false;
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void CargarDatos(string Nom_Proveedor)
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
    }
}
