using Minimarket_BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimarket_ADO
{

    public class StockADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;


        public DataTable ListarStock()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ListarStockProductos";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Stock");
                return dts.Tables["Stock"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public StockBE ConsultarProducto(String strCodigo)
        {

            try
            {
                //Codifique
                StockBE objStockBE = new StockBE();
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


                    objStockBE.Id_Producto = dtr["Id_Producto"].ToString();
                    objStockBE.Nom_Producto = dtr["Nom_Producto"].ToString();
                    objStockBE.Des_UM = dtr["Des_UM"].ToString();

                    objStockBE.Id_UM = Convert.ToInt16(dtr["Id_UM"]);
                    objStockBE.Stk_Tienda = Convert.ToInt16(dtr["Stk_Trastienda"]);

                }
                dtr.Close();
                return objStockBE;


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
