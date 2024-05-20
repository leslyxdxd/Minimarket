using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BE
{
    public class StockBE
    {
        public String Id_Stock { get; set; }

        public int Stk_Tienda { get; set; }

        public int Stk_Trastienda { get; set; }
        public Int16 Movimiento_Tras { get; set; }

        public Int16 Total_Mov_Tras { get; set; }

        public Int16 Movimiento_Venta { get; set; }
        public Int16 Total_Mov_Ven { get; set; }

        public String Id_Producto { get; set; }
        public String Nom_Producto { get; set; }
        public decimal Precio_Unitario { get; set; }
    
        public int Estado { get; set; }
    }
}
