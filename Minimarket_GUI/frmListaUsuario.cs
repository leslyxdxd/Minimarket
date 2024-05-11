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
using static System.Net.Mime.MediaTypeNames;



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

        }
        private void btnInhabilitar_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dtgUsuario.SelectedRows.Count > 0)
            {
                // Obtiene el Login_Usuario y el nivel de usuario de la fila seleccionada
                string loginUsuario = dtgUsuario.SelectedRows[0].Cells["Login_Usuario"].Value.ToString();
                string nivelUsuario = dtgUsuario.SelectedRows[0].Cells["Niv_Usuario"].Value.ToString();

                // Verifica si el usuario ya está inhabilitado
                if (dtgUsuario.SelectedRows[0].Cells["Est_Usuario"].Value.ToString() == "2")
                {
                    MessageBox.Show("El usuario ya está inhabilitado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método sin continuar
                }

                // Verifica si el usuario es administrador (nivel de usuario 1)
                if (nivelUsuario == "1")
                {
                    MessageBox.Show("No es posible inhabilitar al administrador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Sale del método sin continuar
                }

                // Muestra un mensaje de confirmación
                DialogResult result = MessageBox.Show("¿Desea inhabilitar el usuario " + loginUsuario + "?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si el usuario confirma la acción
                if (result == DialogResult.Yes)
                {
                    // Crea un objeto UsuariosBE con el Login_Usuario seleccionado
                    UsuariosBE usuario = new UsuariosBE();
                    usuario.Login_Usuario = loginUsuario;

                    try
                    {
                        // Intenta inhabilitar el usuario
                        if (objUsuarioBL.InhabilitarUsuario(usuario))
                        {
                            // Si se inhabilita correctamente, actualiza la grilla
                            CargarDatos("");
                            MessageBox.Show("Usuario inhabilitado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Error al inhabilitar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dtgUsuario.SelectedRows.Count > 0)
            {
                // Obtiene el Login_Usuario de la fila seleccionada
                string loginUsuario = dtgUsuario.SelectedRows[0].Cells["Login_Usuario"].Value.ToString();

                // Crea un objeto UsuariosBE con el Login_Usuario seleccionado
                UsuariosBE usuario = new UsuariosBE();
                usuario.Login_Usuario = loginUsuario;

                try
                {
                    // Verifica si el usuario ya está habilitado
                    if (dtgUsuario.SelectedRows[0].Cells["Est_Usuario"].Value.ToString() == "1")
                    {
                        MessageBox.Show("El usuario ya está habilitado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return; // Sale del método sin continuar
                    }

                    // Intenta habilitar al usuario
                    if (objUsuarioBL.HabilitarUsuario(usuario))
                    {
                        // Si se habilita correctamente, actualiza la grilla
                        CargarDatos("");
                        MessageBox.Show("Usuario habilitado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al habilitar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

     
        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
    }
}
