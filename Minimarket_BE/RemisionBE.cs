using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BE
{
    public class RemisionBE
    {
       
        public int Id_Detalle { get; set; }


        public String Id_Remision { get; set; }

        public String Id_Proveedor { get; set; }

        public String Id_Producto{ get; set; }
        public Decimal PrecioUnitario{ get; set; }
       
        public int Cantidad { get; set; }
      
 
        public Decimal Total { get; set; }
        

   
        
       
        public DateTime Fec_Registro { get; set; }
       
        public String Usu_Registro { get; set; }
       
        public DateTime Fec_Ult_Mod { get; set; }
       
        public String Usu_Ult_Mod { get; set; }
      
        public Int16 Estado { get; set; }

      

    }

}

