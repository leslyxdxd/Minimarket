using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minimarket_BE;
using Minimarket_BL;

namespace Minimarket_GUI
{
    public partial class frmInsertarUsuario : Form
    {
        UsuariosBL objUsuarioBL = new UsuariosBL();
        UsuariosBE objUsuarioBE = new UsuariosBE();

        public frmInsertarUsuario()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text.Trim() == String.Empty || txtPassword.Text.Trim() == String.Empty) 
                {
                    throw new Exception("El ingreso del usuario y la contraseña son obligatorios");

                }


                objUsuarioBE.Login_Usuario = txtNombre.Text.Trim();
                objUsuarioBE.Pass_Usuario = txtPassword.Text.Trim();

                if (otpGerenteAlmacen.Checked == true)
                {
                    objUsuarioBE.Niv_Usuario = 2;
                }
                else if (otpGerenteTienda.Checked == true)
                {
                    objUsuarioBE.Niv_Usuario = 3;
                }
                else
                {
                    throw new Exception("Debe seleccionar un rol al crear un usuario");

                }

                objUsuarioBE.Usu_Registro = clsCredenciales.Login_Usuario;

                if (objUsuarioBL.InsertarUsuario(objUsuarioBE) == true)
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

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmInsertarUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
