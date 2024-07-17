//Using...

using Minimarket_BE;
using Minimarket_BL;
using ProyVentas_GUI;
using System.Data;



namespace Minimarket_GUI
{

    public partial class frmLogin : Form
    {
        int intentos = 0;// Para cantidad de intentos fallidos
        int tiempo = 30; // Para cantidad de segundos como limite de tiempo para ingresar credenciales

        UsuariosBE objUsuariosBE = new UsuariosBE();
        UsuariosBL objUsuariosBL = new UsuariosBL();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {



            if (txtLogin.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                objUsuariosBE = objUsuariosBL.ConsultarUsuarios(txtLogin.Text.Trim());

                if (objUsuariosBE.Login_Usuario == null)
                {
                    intentos += 1;
                    ValidaAccesos();
                    MessageBox.Show("Usuario no existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (objUsuariosBE.Login_Usuario == txtLogin.Text.Trim() && objUsuariosBE.Pass_Usuario == txtPassword.Text.Trim())
                { 

                    if (objUsuariosBE.Est_Usuario == 1) // Verifica si el usuario está habilitado
                    {
                        this.Hide();
                        

                        clsCredenciales.Login_Usuario = objUsuariosBE.Login_Usuario;
                        clsCredenciales.Niv_Usuario = objUsuariosBE.Niv_Usuario;
                        clsCredenciales.Pass_Usuario = objUsuariosBE.Pass_Usuario;


                        MDIPrincipal mdi = new MDIPrincipal();
                        mdi.ShowDialog();
                        

                    }
                    else
                    {
                        MessageBox.Show("Usuario inhabilitado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña obligatorios", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                intentos += 1;
                ValidaAccesos();
            }
        }




        private void ValidaAccesos()
        {
            if (intentos == 3)
            {
                MessageBox.Show("Lo sentimos,  sobrepaso el numero de intentos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }

        }


     

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            Application.Exit();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            // Para al pulsar Enter acceder al MDI...
            if (e.KeyCode == Keys.Enter)
            {
                btnAceptar.PerformClick();

            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

    }
}
