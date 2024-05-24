using Minimarket_BE;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_ADO
{
    public class MovimientoADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public MovimientoBE ConsultarProducto(String strCodigo)
        {

            try
            {
                //Codifique
                MovimientoBE objMovimientoBE = new MovimientoBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ConsultarProductoStock";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Producto", strCodigo);


                //Abrimos y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();



                if (dtr.HasRows == true)
                {
                    dtr.Read();


                    objMovimientoBE.Id_Producto = dtr["Id_Producto"].ToString();
                    objMovimientoBE.Nom_Producto = dtr["Nom_Producto"].ToString();
                    objMovimientoBE.Des_UM = dtr["Des_UM"].ToString();

                    objMovimientoBE.Id_UM = Convert.ToInt16(dtr["Id_UM"]);
                    objMovimientoBE.Stk_Tienda = Convert.ToInt16(dtr["Stk_Tienda"]);

                }
                dtr.Close();
                return objMovimientoBE;


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }



        }
    }
}
