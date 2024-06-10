namespace Minimarket_BE
{
    public class BoletaBE
    {
        public String Id_Boleta { get; set; }

        public DateTime Fecha { get; set; }

        public DateTime Fec_Registro { get; set; }

        public String Usu_Registro { get; set; }    

        public DateTime Fec_Ult_Mod {  get; set; }  

        public String Usu_Ult_Mod { get; set; } 

        public String Nro_boleta {  get; set; } 

        public String Nombres_Cliente { get; set; }

        public String Apellidos_Cliente { get; set; }   

        public String Dni_Cliente { get; set; }

        public List<Detalle_Boleta> Detalle_Boleta {  get; set; }

    }
}
