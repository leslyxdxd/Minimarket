using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BE
{
    public class ProductoBE
    {
        public String Id_Producto{ get; set; }
        public String Nom_Producto { get; set; }

        public decimal Precio_Unitario { get; set; }


        public int Id_Cat { get; set; }
        public int Id_Proveedor { get; set; }
        public int Id_UM{ get; set; }

        public String Nom_Proveedor { get; set; }
        public String Des_UM { get; set; }
        public String Des_Cat { get; set; }

        public DateTime Fec_Registro { get; set; }

        public String Usu_Registro { get; set; }

        public DateTime Fec_Ult_Mod { get; set; }

        public String Usu_Ult_Mod { get; set; }

        public int cantidadTotal { get; set; }

        public int Stk_Tienda { get; set; }

        public int Stk_Trastienda { get; set; }

        public int Estado { get; set; }
    }
}
