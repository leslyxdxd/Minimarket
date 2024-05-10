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

namespace Minimarket_GUI
{
    public partial class frmInsertarUsuario : Form
    {
        UsuariosBL objUsuarioBL = new UsuariosBL();
        UsuariosBE objUsuarioBE = new UsuariosBE();

        public frmInsertarUsuario()
        {
            InitializeComponent();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
