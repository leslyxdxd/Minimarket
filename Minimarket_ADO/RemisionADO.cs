using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Minimarket_BE;


namespace Minimarket_ADO
{
    public class RemisionADO
    {

        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;



        public DataTable ListarGuiasProveedoresFechas(String strCodigo, DateTime FecIni, DateTime FecFin)
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarGuiasProveedoresFechas";
                cmd.Parameters.Clear();


                //parametros del store procedure
                cmd.Parameters.AddWithValue("@Id_Proveedor", strCodigo);
                cmd.Parameters.AddWithValue("@fecini", FecIni);
                cmd.Parameters.AddWithValue("@fecfin", FecFin);


                ada = new SqlDataAdapter(cmd);
                DataSet dts = new DataSet();

                ada.Fill(dts, "Remision");
                return dts.Tables["Remision"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

          

        }





    }




}
