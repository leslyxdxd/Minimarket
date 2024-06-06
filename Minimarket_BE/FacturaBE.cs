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
    }
}
