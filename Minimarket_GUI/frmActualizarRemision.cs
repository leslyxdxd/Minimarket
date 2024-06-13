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
    public partial class frmActualizarRemision : Form
    {


        RemisionBL objRemisionBL = new RemisionBL();
        RemisionBE objRemisionBE = new RemisionBE();


        public frmActualizarRemision()
        {
            InitializeComponent();
        }


        public String Id_Remision { get; set; }

        private void ActualizarRemision_Load(object sender, EventArgs e)
        {

            try
            {  //Mostramos los datos del proveedor a actualizar 

                objRemisionBE = objRemisionBL.ConsultarGuiaRemision(this.Id_Remision);
                lblNumeroGuia.Text = objRemisionBE.Num_Guia;
                lblDireccion.Text = objRemisionBE.Direc_Proveedor;
                lblRuc.Text = objRemisionBE.RUC;
                lblCorreo.Text = objRemisionBE.Correo;
                lblTel.Text = objRemisionBE.Telefono;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    }
}
