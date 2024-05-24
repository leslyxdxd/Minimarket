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
        StockBL objStockBL = new StockBL();
        StockBE objStockBE = new StockBE();



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
                objStockBE = objStockBL.ConsultarProducto(this.Codigo);


                lblCodigo.Text = objStockBE.Id_Producto;
                lblProducto.Text = objStockBE.Nom_Producto;
                lblStockDis.Text = objStockBE.Stk_Trastienda.ToString();
                lblUM.Text = Convert.ToInt16(objStockBE.Id_UM).ToString();

                lblUNI.Text = objStockBE.Des_UM;

                DataTable dt2 = objStockBL.ListarStock();
                DataRow dtr;
                dtr = dt2.NewRow();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
