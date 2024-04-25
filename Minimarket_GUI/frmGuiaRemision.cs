using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using ProyVentas_BL;
//using ProyVentas_BE;
namespace ProyVentas_GUI
{
    public partial class frmGuiaRemision : Form
    {
       // FacturaBL objFacturaBL = new FacturaBL();
        //ClienteBL objClienteBL = new ClienteBL();
        //ClienteBE objClienteBE = new ClienteBE();

        public frmGuiaRemision()
        {
            InitializeComponent();
        }

        private void frmConsFacturasCliente_Load(object sender, EventArgs e)
        {
            try
            {               

                // Desactivamos la generacion de columnas automaticas del datagrid...
                dtgFacturas.AutoGenerateColumns = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

         private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
               // Codifique

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
              

        private void LimpiarResultados()
        {
            // Limpiamos los label  de resultado...
            foreach (Control miControl in this.Controls)
            {
                if (miControl.Name.StartsWith("lbl") == true)
                {
                    miControl.Text = String.Empty;
                }

            }
            // Limpiamos el datagridview
            dtgFacturas.DataSource = null;
          
        }
    }
}
