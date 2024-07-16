using System;

namespace Minimarket_BE
{
    public class FacturaBE
    {
        public string direccion { get; set; }
        public string direccion_completa { get; set; }
        public string ruc { get; set; }
        public string nombre_o_razon_social { get; set; }
        public string estado { get; set; }
        public string condicion { get; set; }
        public string departamento { get; set; }
        public string provincia { get; set; }
        public string distrito { get; set; }
        public string ubigeo_sunat { get; set; }
        public string[] ubigeo { get; set; }
        public bool? es_agente_de_retencion { get; set; }
        public bool? es_buen_contribuyente { get; set; }
        public DateTime Fec_Registro { get; set; }

        public String Usu_Registro { get; set; }

        public DateTime Fec_Ult_Mod { get; set; }

        public String Usu_Ult_Mod { get; set; }

        //Agregados
        public Int16 MetodoPago { get; set; }
        public Decimal EfectivoRecibido { get; set; }
        public float Devolucion { get; set; }

        public List<Detalle_FacturaBE> Detalle_Factura { get; set; }
    }
}
