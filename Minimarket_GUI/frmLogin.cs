using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Windows.Forms;

//Using...

using Minimarket_BE;
using Minimarket_BL;
using Minimarket_GUI;
using ProyVentas_GUI;



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
            if (txtLogin.Text.Trim() != "" & txtPassword.Text.Trim() != "")
            {
                objUsuariosBE = objUsuariosBL.ConsultarUsuarios(txtLogin.Text.Trim());


                if (objUsuariosBE.Login_Usuario == null)
                {
                    // Si las credenciales son correctas...

                    intentos += 1;
                    ValidaAccesos();
                    throw new Exception("Usuario no Existe");

                }
                else if (objUsuariosBE.Login_Usuario == txtLogin.Text.Trim() && objUsuariosBE.Pass_Usuario == txtPassword.Text.Trim())
                {
                    this.Hide();
                    timer1.Enabled = false;

                    clsCredenciales.Login_Usuario = objUsuariosBE.Login_Usuario;
                    clsCredenciales.Niv_Usuario = objUsuariosBE.Niv_Usuario;
                    clsCredenciales.Pass_Usuario = objUsuariosBE.Pass_Usuario;


                    MDIPrincipal mdi = new MDIPrincipal();
                    mdi.ShowDialog();


                }


                else
                {
                    MessageBox.Show("Usuario o Password incorrectos",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intentos += 1;
                    ValidaAccesos();

                }
            }
            else
            {
                MessageBox.Show("Usuario o Password obligatorios",
                    "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            // Cada segundo se decrementa la variable tiempo  en menos 1, reflejando esto en el texto del formulario
            // para que el usuario sepa cuantos segundos le van restando para ingresar sus credenciales.
            tiempo -= 1;
            this.Text = "Ingrese su Usuario y contraseña. Le quedan..." + tiempo;

            // Si la variable tiempo llega a 0 , se le indica que el tiempo expiro y saldremos de la aplicacion.
            if (tiempo == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Lo sentimos, sobrepaso el tiempo de espera.", "Mensaje",
                                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();

            }

        }

        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Enabled = false;
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
