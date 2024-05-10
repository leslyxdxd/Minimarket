using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Minimarket_BL;



namespace ProyVentas_GUI
{
    public partial class frmListaUsuario : Form
    {
        UsuariosBL objUsuarioBL = new UsuariosBL();
        DataView dtv;

        public frmListaUsuario()
        {
            InitializeComponent();
        }

        public void CargarDatos(String strFiltro)
        {
            // Construimos el dataview en base al datatable devuelto por el metodo ListarCategoria
            dtv = new DataView(objUsuarioBL.ListarUsuarios());
            // Y se filtra el dataview segun la cadena strFiltro recibido como parametro
            dtv.RowFilter = "Login_Usuario like  '%" + strFiltro + "%'";
            // Se enlaza el datagrid al dataview ya filtrado
            dtgUsuario.DataSource = dtv;
            // Mostramos la cantidad de filas filtradas
            lblRegistros.Text = dtgUsuario.Rows.Count.ToString();
        }
        private void CategoriaMan01_Load(object sender, EventArgs e)
        {

            try
            {
                // Configuramos el datagrid para que no se generen columnas automaticamente
                dtgUsuario.AutoGenerateColumns = false;
                // Invocamos al metodo para cargar los datos              
                CargarDatos("");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

    

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgCategoria_DoubleClick(object sender, EventArgs e)
        {
            btnActualizar.PerformClick();
        }
    }
}
