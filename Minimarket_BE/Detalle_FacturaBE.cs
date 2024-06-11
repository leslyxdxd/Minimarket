using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BE
{
    public class Detalle_FacturaBE
    {
        public int Id_DetalleFactura { get; set; }

        public String Id_Factura{ get; set; }

        public String Id_Producto { get; set; }

        public decimal Total { get; set; }

        public Int16 Cantidad { get; set; }

        public float Igv { get; set; }

        public float Subtotal { get; set; }

    }
}
