﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_BE
{
    public class RemisionBE
    {
       
        public Int16 Id_Detalle { get; set; }
        public String Num_Guia { get; set; }
        public String Id_Remision { get; set; }
        
        public String Id_Proveedor { get; set; }
        public String Nom_Proveedor { get; set; }
        public String Direc_Proveedor { get; set; }

        public String Id_Transporte { get; set; }
        public String Empresa_Transporte { get; set; }
        
        public String Ruc_Transporte { get; set; }
        public String Placa_Trasporte { get; set; }
        public String Licencia_Transporte { get; set; }

        public String Marca_Trasporte { get; set; }
        public String Direccion_Empresa { get; set; }

        public String RUC { get; set; }
        public Int16 Id_Cat { get; set; }
        public String Correo { get; set; }
        public String Telefono { get; set; }
        public String Id_Producto{ get; set; }

        public String Marca { get; set; }
        public String Nom_Producto { get; set; }
        public String Observaciones { get; set; }
        public String Punto_Partida { get; set; }
        public String Punto_Llegada{ get; set; }
        public String Des_Cat { get; set; }
        public String Des_UM { get; set; }
        public Int16 Id_UM_Producto { get; set; }
        public Int16 Id_UM_Remision { get; set; }
        public String Des_UM_Producto { get; set; }
        public String Des_UM_Remision{ get; set; }
        public Decimal Peso_Carga { get; set; }
        public int  Id_UM { get; set; }

        public int Cantidad { get; set; }
      
        public Decimal Total { get; set; }

        public DateTime FechaIni {get; set; }

        public DateTime FechaFin { get; set; }

        public DateTime Fec_Registro { get; set; }
       
        public String Usu_Registro { get; set; }
       
        public DateTime Fec_Ult_Mod { get; set; }
       
        public String Usu_Ult_Mod { get; set; }
      
        //public Int16 Estado { get; set; }

        public String Estado { get; set; }



    }

}

