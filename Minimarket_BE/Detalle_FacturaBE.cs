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
        public String Numero_Factura { get; set; }
        public String Ruc { get; set; }
        public String Nom_Producto { get; set; }
        public String RazonSocial { get; set; }
        public String Id_Producto { get; set; }
        public DateTime Fec_Factura { get; set; }
        public DateTime Fec_Registro{ get; set; }
        public decimal Total { get; set; }
        public String Marca { get; set; }
        public Int16 Cantidad { get; set; }
        public String Des_UM { get; set; }
        public Decimal Igv { get; set; }

        //Agregados
        public Int16 MetodoPago { get; set; }
        public Decimal EfectivoRecibido { get; set; }
        public float Devolucion { get; set; }
        public Decimal Subtotal { get; set; }

    }
}
