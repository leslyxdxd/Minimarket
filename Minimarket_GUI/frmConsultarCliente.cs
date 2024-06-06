using Minimarket_BE;
using Minimarket_BL;
using System;
using System.Windows.Forms;

namespace Minimarket_GUI
{
    public partial class frmConsultarCliente : Form
    {
        ClienteBL objClienteBL = new ClienteBL();

        public frmConsultarCliente()
        {
            InitializeComponent();
        }

        private async void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string dni = txtDni.Text.Trim();
                if (!string.IsNullOrEmpty(dni))
                {
                    ClienteBE cliente = await objClienteBL.ObtenerClientePorDniAsync(dni);
                    if (cliente != null)
                    {
                        // Depuración: Verifica que los datos se están obteniendo correctamente
                        MessageBox.Show($"Datos obtenidos:\nNombre: {cliente.nombres}\nApellido Paterno: {cliente.apellido_paterno}\nApellido Materno: {cliente.apellido_materno}\nNombre Completo: {cliente.nombre_completo}\nCódigo de Verificación: {cliente.codigo_verificacion}\nNúmero: {cliente.numero}", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        lblNombre.Text = cliente.nombres;
                        lblCodVeri.Text = cliente.codigo_verificacion.ToString();
                        lblApellidoMA.Text = cliente.apellido_materno;
                        lblApellidoPa.Text = cliente.apellido_paterno;
                        lblNomCompleto.Text = cliente.nombre_completo;
                        lblNumero.Text = cliente.numero;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró información para el DNI proporcionado.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, ingrese un DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al consultar el DNI: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}
