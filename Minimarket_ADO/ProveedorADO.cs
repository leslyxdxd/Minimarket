
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Agregar....
using System.Data;
using System.Data.SqlClient;
using Minimarket_BE;

namespace Minimarket_ADO



{
    public class ProveedorADO
    {
        // Instancias.....
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;
        SqlDataAdapter ada;

        public DataTable ListarProveedor()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedor";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Proveedor");
                return dts.Tables["Proveedor"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public ProveedorBE ConsultarProveedor(String strCodigo)
        {

            try
            {
                //Codifique
                ProveedorBE objProveedorBE = new ProveedorBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Id_Proveedor", strCodigo);


                //Abrimos y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();



                if (dtr.HasRows == true)
                {
                    dtr.Read();


                    objProveedorBE.Id_Proveedor = dtr["Id_Proveedor"].ToString();
                    objProveedorBE.Nom_Proveedor = dtr["Nom_Proveedor"].ToString();
                 

                    objProveedorBE.Direc_Proveedor = dtr["Direc_Proveedor"].ToString();
                    objProveedorBE.RUC = dtr["RUC"].ToString();
                    objProveedorBE.Telefono = dtr["Telefono"].ToString();
                    objProveedorBE.Correo = dtr["Correo"].ToString();

                    objProveedorBE.Estado = Convert.ToInt16(dtr["Estado"]);

                }
                dtr.Close();
                return objProveedorBE;


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
