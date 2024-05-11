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
    public class UsuariosADO
    {
        ConexionADO MiConexion = new ConexionADO();
        SqlConnection cnx = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dtr;



        public UsuariosBE ConsultarUsuarios(String strLogin) 
        {
            UsuariosBE objUsuariosBE = new UsuariosBE();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ConsultarUsuarios";

            //Agregamos el parametro
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@Login_Usuario", strLogin);

            try
            {
                cnx.Open();
                dtr = cmd.ExecuteReader();
                if (dtr.HasRows == true)
                {
                    dtr.Read();
                    objUsuariosBE.Login_Usuario = dtr["Login_Usuario"].ToString();
                    objUsuariosBE.Pass_Usuario = dtr["Pass_Usuario"].ToString();
                    objUsuariosBE.Niv_Usuario = Convert.ToInt16(dtr["Niv_Usuario"]);
                    objUsuariosBE.Est_Usuario = Convert.ToInt16(dtr["Est_usuario"]);
                    objUsuariosBE.Usu_Registro = dtr["Usu_Registro"].ToString();
                }
                dtr.Close();
                return objUsuariosBE;

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

     public Boolean InsertarUsuario(UsuariosBE objUsuarioBE)
        {

      
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login_Usuario", objUsuarioBE.Login_Usuario);
                cmd.Parameters.AddWithValue("@Pass_Usuario", objUsuarioBE.Pass_Usuario);
                cmd.Parameters.AddWithValue("@Niv_Usuario", objUsuarioBE.Niv_Usuario);
                cmd.Parameters.AddWithValue("@Usu_Registro", objUsuarioBE.Usu_Registro);

                //Abrimos y ejecutamos

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SqlException x)
            {
                throw new Exception(x.Message);
                return false;
            }
            finally
            {
                if (cnx.State == ConnectionState.Open)
                {
                    cnx.Close();
                }

            }
        }


        public DataTable ListarUsuarios()
        {
            DataSet dts = new DataSet();
            cnx.ConnectionString = MiConexion.GetCnx();
            cmd.Connection = cnx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "usp_ListarUsuarios";

            try
            {
                cmd.Parameters.Clear();
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Usuarios");
                return dts.Tables["Usuarios"];

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public Boolean InhabilitarUsuario(UsuariosBE objUsuarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InhabilitarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login_Usuario", objUsuarioBE.Login_Usuario);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
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

        public Boolean HabilitarUsuario(UsuariosBE objUsuarioBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_HabilitarUsuario";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Login_Usuario", objUsuarioBE.Login_Usuario);

                cnx.Open();
                cmd.ExecuteNonQuery();
                return true;
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
