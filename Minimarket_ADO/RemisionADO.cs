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



            public DataTable ListarGuiaRemision()
            {

                try
                {

                    // Codifique
                    cnx.ConnectionString = MiConexion.GetCnx();
                    cmd.Connection = cnx;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "usp_ListarDetalleRemision ";
                    cmd.Parameters.Clear();
                    DataSet dts = new DataSet();
                    ada = new SqlDataAdapter(cmd);
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
