using Minimarket_ADO;
using Minimarket_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BL
{
    public class UsuariosBL
    {
        UsuariosADO objUsuariosADO = new UsuariosADO();


        public DataTable ListarUsuarios()
        {
            return objUsuariosADO.ListarUsuarios();

        }

        public UsuariosBE ConsultarUsuarios(String strLogin)
        {
            return objUsuariosADO.ConsultarUsuarios(strLogin);
        }

        public Boolean InsertarUsuario(UsuariosBE objUsuariosBE)
        {
            return objUsuariosADO.InsertarUsuario(objUsuariosBE);
        }

        public Boolean InhabilitarUsuario(UsuariosBE objUsuariosBE)
        {
            return objUsuariosADO.InhabilitarUsuario(objUsuariosBE);
        }

        public Boolean HabilitarUsuario(UsuariosBE objUsuariosBE)
        {
            return objUsuariosADO.HabilitarUsuario(objUsuariosBE);
        }
    }
}
