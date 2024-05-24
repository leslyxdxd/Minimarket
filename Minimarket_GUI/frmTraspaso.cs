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
                objStockBE = objStockBL.ConsultarProducto(this.Codigo);
                lblProducto.Text = objStockBE.Nom_Producto;
                lblStockDis.Text = Convert.ToInt16(objStockBE.Stk_Trastienda).ToString();
                lblUNI.Text = objStockBE.Des_UM;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
