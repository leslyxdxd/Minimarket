using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BE
{
    public class MovimientoBE
    {
        public int Id_Movimiento { get; set; }


        public int Trastienda_Mov { get; set; }

        public DateTime Fec_Registro { get; set; }

        public String Usu_Registro { get; set; }

        public String Id_Stock { get; set; }


        //
        public int Stk_Tienda { get; set; }

        public int Stk_Trastienda { get; set; }
        public int Id_UM { get; set; }
        public String Des_UM { get; set; }

        public String Id_Producto { get; set; }
        public String Nom_Producto { get; set; }
       
       
    }
}
