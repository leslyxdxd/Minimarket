using Minimarket_BE;
using Minimarket_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Agregar...

namespace ProyVentas_GUI
{
    public partial class frmActualizarProveedor : Form
    {

        ProveedorBL objProveedorBL = new ProveedorBL();
        ProveedorBE objProveedorBE = new ProveedorBE();


        public frmActualizarProveedor()
        {
            InitializeComponent();
        }

        // IMPORTANTE: Creamos la propiedad Codigo ,que recepcionara el valor del codigo del proveedor
        // a actualizar enviado desde el formulario ProveedorMan01


        public String Codigo { get; set; }

        private void ProveedorMan03_Load(object sender, EventArgs e)
        {
            try
            {
        

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private void CargarUbigeo(String IdDepa, String IdProv, String IdDist)
        {
        


        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
           {
            //    Validar que este con valor la razon social
            //    if (txtRS.Text.Trim() == String.Empty)
            //    {
            //        throw new Exception("La razon social es obligatoria");
            //    }
            //    Validamos que el ruc este lleno
            //    if (mskRuc.MaskFull == false)
            //    {
            //        throw new Exception("El ruc debe tener 11 caracteres");
            //    }

            //    Pasamos los valores a las propiedades de la instancia
            //    objProveedorBE.Raz_soc_prv = txtRS.Text.Trim();
            //    objProveedorBE.Dir_prv = txtDir.Text.Trim();
            //    objProveedorBE.Tel_prv = txtTel.Text.Trim();
            //    objProveedorBE.Ruc_prv = mskRuc.Text.Trim();
            //    objProveedorBE.Rep_ven = txtRepVen.Text.Trim();

            //    Recuerde que el IdUbigeo es la concatenacion de los valores del IdDepartamento,
            //    Id Provincia y Id Distrito seleccionados de los respectivos combos
            //    objProveedorBE.Id_Ubigeo = cboDepartamento.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
            //    cboProvincia.SelectedValue.ToString();

            //    Se le asignara por ahora el usuario jleon como usuario de registro
            //    objProveedorBE.Usu_Ult_Mod = clsCredenciales.Usuario;

            //    Checked
            //    objProveedorBE.Est_prv = Convert.ToInt16(chkEstado.Checked);

            //    if (objProveedorBL.ActualizarProveedor(objProveedorBE) == true)
            //    {
            //        this.Close();
            //    }
            //    else
            //    {
            //        throw new Exception("No se inserto el registro");
            //    }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }
        }


        private void cboDepartamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }

        private void cboProvincia_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
