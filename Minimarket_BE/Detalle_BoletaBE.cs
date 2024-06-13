using System;

namespace Minimarket_BE
{
    public class Detalle_BoletaBE
    {
        public int Id_DetalleBoleta { get; set; }
        public string Id_Boleta { get; set; }
        public string Id_Producto { get; set; }
        public decimal Total { get; set; }
        public Int16 Cantidad { get; set; }
        public float Igv { get; set; }
        public float Subtotal { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Fec_Registro { get; set; }
        public string Usu_Registro { get; set; }
        public DateTime Fec_Ult_Mod { get; set; }
        public string Usu_Ult_Mod { get; set; }
        public string Nro_boleta { get; set; }
        public string Nombres_Cliente { get; set; }
        public string Apellidos_Cliente { get; set; }
        public string Dni_Cliente { get; set; }
        public string Nom_Producto { get; set; }
        public string Marca { get; set; }
        public string Des_UM { get; set; }
    }
}
