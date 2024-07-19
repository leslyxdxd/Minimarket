using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minimarket_ADO;

namespace ProyVentas_ADO
{
    public class UnidadMedidaADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarUM()
        {
            try
            {
                 DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarUM";
           
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Unidades");
                return dts.Tables["Unidades"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable ListarUM_Pro()
        {
            try
            {
                DataSet dts = new DataSet();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarUM_Pro";

                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Unidades");
                return dts.Tables["Unidades"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable ConsultarUMXRemision(String strCodigo)
        {
            try
            {
                
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_UMXRemision";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdRemision", strCodigo);
                SqlDataAdapter miada;
                DataSet dts = new DataSet();
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Transportista");
                return dts.Tables["Transportista"];
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }


    }
}
