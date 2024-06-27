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
                //Aqui esta el Id_Stock
                objStockBE = objStockBL.ConsultarProducto(this.Codigo);
                lblProducto.Text = objStockBE.Nom_Producto;
                lblStockDis.Text = objStockBE.Stk_Trastienda.ToString();
                lblUNI.Text = objStockBE.Des_UM;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el código del stock no sea nulo o vacío
                if (string.IsNullOrEmpty(this.Codigo))
                {
                    MessageBox.Show("El código de stock no puede estar vacío.");
                    return; // Detener la ejecución si la validación falla
                }

                // Obtener el stock disponible del Label y convertirlo a un entero
                int stockDisponible;
                if (!int.TryParse(lblStockDis.Text, out stockDisponible))
                {
                    MessageBox.Show("El valor de stock disponible no es válido.");
                    return; // Detener la ejecución si la validación falla
                }

                // 1. Asignar el código al identificador de stock
                objMovimientoBE.Id_Stock = this.Codigo;

                // 2. Obtener la cantidad del control NumericUpDown y validar que sea mayor a cero
                int cantidad = (int)Cantidad.Value;
                if (cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser mayor a cero.");
                    return; // Detener la ejecución si la validación falla
                }

                // Validar que la cantidad no cause que el stock disponible caiga por debajo de 20
                if (stockDisponible - cantidad < 20)
                {
                    MessageBox.Show($"La cantidad a transferir es demasiado alta. El stock debe quedar con al menos 20 unidades. Stock disponible: {stockDisponible}, máximo transferible: {stockDisponible - 20}");
                    return; // Detener la ejecución si la validación falla
                }

                // 3. Asignar la cantidad al movimiento de tienda
                objMovimientoBE.Movimiento_Tienda = cantidad;

                // Validar que el usuario de registro no sea nulo o vacío
                if (string.IsNullOrEmpty(clsCredenciales.Login_Usuario))
                {
                    MessageBox.Show("El usuario de registro no puede estar vacío.");
                    return; // Detener la ejecución si la validación falla
                }

                // 4. Asignar el usuario de registro
                objMovimientoBE.Usu_Registro = clsCredenciales.Login_Usuario;

                // Intentar insertar el movimiento
                if (objMovimientoBL.InsertarMovimiento(objMovimientoBE))
                {
                    MessageBox.Show("Se ha transferido " + cantidad + " productos de la trastienda.");


                    this.Close(); // Cerrar el formulario actual
                }
                else
                {
                    throw new Exception("No se pudo hacer el traspaso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al transferir los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
  


