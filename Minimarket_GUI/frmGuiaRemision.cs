using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Minimarket_BL;
using Minimarket_BE;
namespace ProyVentas_GUI
{
    public partial class frmGuiaRemision : Form
    {
        
        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();


        public frmGuiaRemision()
        {
            InitializeComponent();
        }

        public String Codigo { get; set; }

        private void frmConsFacturasCliente_Load(object sender, EventArgs e)
        {
            try
            {

                // Cargamos los combos...

                //codifique
                //invocamos la methodo consultar..
                objProveedorBE = objProveedorBL.ConsultarProveedor(this.Codigo);





                lblCodigo.Text = objProveedorBE.Id_Proveedor;
                lblNombre.Text = objProveedorBE.Nom_Proveedor;
                lblDireccion.Text = objProveedorBE.Direc_Proveedor;
                lblRuc.Text = objProveedorBE.RUC;
                lblCorreo.Text = objProveedorBE.Correo;
            
                lblTel.Text = objProveedorBE.Telefono;




                lblEstados.Text = objProveedorBE.Estado == 1 ? "Activo" : "Inactivo";



                DataTable dt2 = objProveedorBL.ListarProveedor();
                DataRow dtr;
                dtr = dt2.NewRow();






            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
