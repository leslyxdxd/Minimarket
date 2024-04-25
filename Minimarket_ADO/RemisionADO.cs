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

        public RemisionBE ConsultarRemision(String strCodigo)
        {

            try
            {
                //Codifique
                RemisionBE objRemisionBE = new RemisionBE();
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ConsultarEstudiante";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Estudiante", strCodigo);


                //Abrimos y ejecutamos...
                cnx.Open();
                dtr = cmd.ExecuteReader();



                if (dtr.HasRows == true)
                {
                    dtr.Read();


                    objEstudianteBE.ID_Estudiante = dtr["ID_Estudiante"].ToString();
                    objEstudianteBE.Nom_Estudiante = dtr["Nom_Estudiante"].ToString();
                    objEstudianteBE.Ape_Estudiante = dtr["Ape_Estudiante"].ToString();
                    objEstudianteBE.FecNa_Estudiante = Convert.ToDateTime(dtr["FecNa_Estudiante"]);
                    objEstudianteBE.Direc_Estudiante = dtr["Direc_Estudiante"].ToString();
                    objEstudianteBE.Correo_Estudiante = dtr["Correo_Estudiante"].ToString();
                    objEstudianteBE.Telef_Estudiante = dtr["Telef_Estudiante"].ToString();

                    objEstudianteBE.DNI_Estudiante = dtr["DNI_Estudiante"].ToString();

                    if (dtr["Foto_Estudiante"] != DBNull.Value)
                    {
                        objEstudianteBE.Foto_Estudiante = (Byte[])dtr["Foto_Estudiante"];
                    }
                    else
                    {
                        objEstudianteBE.Foto_Estudiante = null;
                    };

                    objEstudianteBE.Estado = Convert.ToInt16(dtr["Estado"]);


                    objEstudianteBE.Id_Ubigeo = dtr["Id_Ubigeo"].ToString();

                }
                dtr.Close();
                return objEstudianteBE;


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
