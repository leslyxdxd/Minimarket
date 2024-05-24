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
    public partial class frmTraspaso : Form
    {
        MovimientoBL objMovimientoBL = new MovimientoBL();
        MovimientoBE objMovimientoBE = new MovimientoBE();
        StockBL objStock = new StockBL();




        public frmTraspaso()
        {
            InitializeComponent();
        }
        public String Codigo { get; set; }

        private void frmTraspaso_Load(object sender, EventArgs e)
        {


            try
            {

                // Cargamos los combos...

                //codifique
                //invocamos la methodo consultar..
                objMovimientoBE = objMovimientoBL.ConsultarProducto(this.Codigo);


                lblCodigo.Text = objMovimientoBE.Id_Producto;
                lblProducto.Text = objMovimientoBE.Nom_Producto;
                lblStockDis.Text = objMovimientoBE.Stk_Trastienda.ToString();

                lblUNI.Text = objMovimientoBE.Des_UM;
               
              
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
