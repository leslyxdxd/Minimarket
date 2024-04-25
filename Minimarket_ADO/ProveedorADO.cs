﻿
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

      /*  public Boolean InsertarProfesor(ProfesorBE objProfesorBE)
        {

            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_InsertarProfesor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nom_Profesor", objProfesorBE.Nom_Profesor);
                cmd.Parameters.AddWithValue("@Apellido_Profesor", objProfesorBE.Apellido_Profesor);

                cmd.Parameters.AddWithValue("@FecNa_Profesor", objProfesorBE.FecNa_Profesor);

                cmd.Parameters.AddWithValue("@Direccion_Profesor", objProfesorBE.Direccion_Profesor);
                cmd.Parameters.AddWithValue("@Correo_Profesor", objProfesorBE.Correo_Profesor);
                cmd.Parameters.AddWithValue("@Telefono_Profesor", objProfesorBE.Telefono_Profesor);

                if (objProfesorBE.Foto_Profesor == null || objProfesorBE.Foto_Profesor.Length == 0)
                {
                    // Si Foto_Profesor es nulo o vacío, asignar DBNull.Value al parámetro
                    cmd.Parameters.Add("@Foto_Profesor", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    // Si hay datos en Foto_Profesor, asignar el valor del arreglo de bytes
                    cmd.Parameters.Add("@Foto_Profesor", SqlDbType.Image).Value = objProfesorBE.Foto_Profesor;
                }




                cmd.Parameters.AddWithValue("@DNI_Profesor", objProfesorBE.DNI_Profesor);
           
                cmd.Parameters.AddWithValue("@Usu_Registro", objProfesorBE.Usu_Registro);
           
        
                cmd.Parameters.AddWithValue("@Estado", objProfesorBE.Estado);

                cmd.Parameters.AddWithValue("@Id_Ubigeo", objProfesorBE.Id_Ubigeo);


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
        public Boolean ActualizarProfesor(ProfesorBE objProfesorBE)
        {
            try
            {
                //Codifique

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ActualizarProfesor";
                cmd.Parameters.Clear();

                cmd.Parameters.AddWithValue("@ID_Profesor", objProfesorBE.ID_Profesor);

                cmd.Parameters.AddWithValue("@Nom_Profesor", objProfesorBE.Nom_Profesor);
                cmd.Parameters.AddWithValue("@Apellido_Profesor", objProfesorBE.Apellido_Profesor);

             
                cmd.Parameters.AddWithValue("@Direccion_Profesor", objProfesorBE.Direccion_Profesor);
                cmd.Parameters.AddWithValue("@Correo_Profesor", objProfesorBE.Correo_Profesor);
                cmd.Parameters.AddWithValue("@Telefono_Profesor", objProfesorBE.Telefono_Profesor);

                cmd.Parameters.AddWithValue("@FecNa_Profesor", objProfesorBE.FecNa_Profesor);
                cmd.Parameters.AddWithValue("@DNI_Profesor", objProfesorBE.DNI_Profesor);
             
              
             
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objProfesorBE.Usu_Ult_Mod);
                cmd.Parameters.AddWithValue("@Estado", objProfesorBE.Estado);

                if (objProfesorBE.Foto_Profesor == null || objProfesorBE.Foto_Profesor.Length == 0)
                {
                    // Si Foto_Profesor es nulo o vacío, asignar DBNull.Value al parámetro
                    cmd.Parameters.Add("@Foto_Profesor", SqlDbType.Image).Value = DBNull.Value;
                }
                else
                {
                    // Si hay datos en Foto_Profesor, asignar el valor del arreglo de bytes
                    cmd.Parameters.Add("@Foto_Profesor", SqlDbType.Image).Value = objProfesorBE.Foto_Profesor;
                }



                cmd.Parameters.AddWithValue("@Id_Ubigeo", objProfesorBE.Id_Ubigeo);


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

        public Boolean EliminarProfesor(String strCodigo)
        {


            try
            {
                //Codifique

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_EliminarProfesor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ID_Profesor", strCodigo);

                //abrimos y ejecutamos
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


        }*/

    }
}
