using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BE
{
    public class ProveedorBE
    {
        // Definimos la entidad de negocio Producto, con todas las propiedades de acuerdo a la estructura 
        // de la tabla Tb_Producto
        public String Id_Proveedor{ get; set; }
        public String Nom_Proveedor { get; set; }

        public String Direc_Proveedor { get; set; }
 
        public String Telefono { get; set; }
        public String Correo { get; set; }


        public String RUC { get; set; }    

        public DateTime Fec_Registro { get; set; }

        public String Usu_Registro { get; set; }

        public DateTime Fec_Ult_Mod { get; set; }

        public String Usu_Ult_Mod { get; set; }

        public int Estado { get; set; }

       
    }
}
