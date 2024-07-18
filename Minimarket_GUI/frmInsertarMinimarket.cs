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
    public partial class frmInsertarMinimarket : Form
    {

        MinimarketBL objMinimarketBL = new MinimarketBL();
        MinimarketBE objMinimarketBE = new MinimarketBE();
        public frmInsertarMinimarket()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == String.Empty)
                {
                    throw new Exception("El nombre del minimarket es necesario");

                }
                if (txtRuc.Text.Trim() == String.Empty)
                {
                    throw new Exception("El RUC del minimarket es necesario");
                }
                if (txtTelefono.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Telefono del minimarket es necesario");
                }
                if (txtDireccion.Text.Trim() == String.Empty)
                {
                    throw new Exception("El Telefono del minimarket es necesario");
                }


                objMinimarketBE.Nombre = txtNombre.Text.Trim();
                objMinimarketBE.Telefono = txtTelefono.Text.Trim();

                objMinimarketBE.Direccion = txtDireccion.Text.Trim();
                objMinimarketBE.Ruc = txtRuc.Text.Trim();
               


                if (objMinimarketBL.InsertarMinimarket(objMinimarketBE) == true)
                {
                    MessageBox.Show("El Usuario se inserto correctamente");
                    this.Close();

                }
                else
                {
                    throw new Exception("Registro no insertado, contacte con TI");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
