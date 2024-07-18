using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Minimarket_BE;
using Minimarket_BL;
using Minimarket_GUI;

namespace ProyVentas_GUI
{
    public partial class MDIPrincipal : Form
    {

        MinimarketBE objminimarketBE = new MinimarketBE();
        MinimarketBL objminimarketBL = new MinimarketBL();
        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

            try
            {
                // Obtener los datos del minimarket desde la base de datos
                MinimarketBE minimarket = objminimarketBL.ObtenerDatosMinimarket();

                // Verificar si se obtuvieron los datos del minimarket
                if (minimarket != null)
                {
                    lblNombre.Text = minimarket.Nombre.ToString();
                }
                else
                {
                    lblNombre.Text = "No hay minimarkets activos";
                }
            }
            catch (Exception ex)
            {
                // Mostrar el error en un cuadro de mensaje
                MessageBox.Show($"Ocurrió un error al obtener los datos del minimarket: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            guna2ImageButton2.HoverState.ImageSize = guna2ImageButton2.ImageSize;

            guna2ImageButton2.PressedState.ImageSize = new Size(
                (int)(guna2ImageButton2.ImageSize.Width * 1.1),  // Incrementar el tamaño en un 10%
                (int)(guna2ImageButton2.ImageSize.Height * 1.1)  // Incrementar el tamaño en un 10%
            );

            guna2ImageButton3.HoverState.ImageSize = guna2ImageButton3.ImageSize;

            guna2ImageButton3.PressedState.ImageSize = new Size(
                (int)(guna2ImageButton3.ImageSize.Width * 1.5),  // Incrementar el tamaño en un 10%
                (int)(guna2ImageButton3.ImageSize.Height * 1.5)  // Incrementar el tamaño en un 10%
            );

            guna2ImageButton1.HoverState.ImageSize = guna2ImageButton1.ImageSize;

            string nombreUsuario = clsCredenciales.Login_Usuario;

            // Definir los nombres personalizados para ciertos usuarios
            string nombrePersonalizado;

            switch (nombreUsuario)
            {
                case "sa":
                    nombrePersonalizado = "Administrador";
                    break;
                case "jordan":
                    nombrePersonalizado = "Gerente de Tienda";
                    break;
                case "lesly":
                    nombrePersonalizado = "Gerente de Almacén";
                    break;
                default:
                    nombrePersonalizado = nombreUsuario; // Si no coincide con ningún usuario específico, mostrar el nombre de usuario normal
                    break;
            }

            // Asignar el nombre personalizado al campo de texto
            this.lblUsuario.Text = nombrePersonalizado;

            if (clsCredenciales.Niv_Usuario == 1)
            {
                // Lógica para nivel de usuario 1
            }
            else if (clsCredenciales.Niv_Usuario == 2)
            {
                // Lógica para nivel de usuario 2
            }
            else if (clsCredenciales.Niv_Usuario == 3)
            {
                // Lógica para nivel de usuario 3
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Para que se cierre
            this.Close();
        }

        private void CloseAllChildForms()
        {
            foreach (Form childForm in this.MdiChildren)
            {
                childForm.Close();
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaProveedores prov01 = new frmListaProveedores();
            prov01.MdiParent = this;
            prov01.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmVentaBoletas frmBoletas = new frmVentaBoletas();
            frmBoletas.MdiParent = this;
            frmBoletas.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaMovimientos frmListaMovimientos = new frmListaMovimientos();
            frmListaMovimientos.MdiParent = this;
            frmListaMovimientos.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaProductos frmc1 = new frmListaProductos();
            frmc1.MdiParent = this;
            frmc1.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaFacturas frmFacturas = new frmListaFacturas();
            frmFacturas.MdiParent = this;
            frmFacturas.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaBoletas frmFacturas = new frmListaBoletas();
            frmFacturas.MdiParent = this;
            frmFacturas.Show();
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmVentaFacturas frmFacturas = new frmVentaFacturas();
            frmFacturas.MdiParent = this;
            frmFacturas.Show();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmGenerarRemision frmGenerar = new frmGenerarRemision();
            frmGenerar.MdiParent = this;
            frmGenerar.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaRemision prov01 = new frmListaRemision();
            prov01.MdiParent = this;
            prov01.Show();
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaUsuario listausu = new frmListaUsuario();
            listausu.MdiParent = this;
            listausu.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaProductosTras frmc1 = new frmListaProductosTras();
            frmc1.MdiParent = this;
            frmc1.Show();
        }

        private void guna2ImageButton3_Click(object sender, EventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de cerrar sesión?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.Yes)
            {
                // Cierra la sesión y regresa al formulario de login o cierra la aplicación
                this.Close();
                // Por ejemplo, puedes mostrar el formulario de login nuevamente
                frmLogin loginForm = new frmLogin();
                loginForm.Show();
            }
        }

        private void guna2Button8_Click_1(object sender, EventArgs e)
        {
            CloseAllChildForms();
            frmListaMinimarket frmc1 = new frmListaMinimarket();
            frmc1.MdiParent = this;
            frmc1.Show();

        }
    }
}
