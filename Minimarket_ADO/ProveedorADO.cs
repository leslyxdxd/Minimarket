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
using System.Globalization;
using System.Net;

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




        public Boolean InsertarProveedorTransporte(ProveedorBE objProveedorBE , TransportistaBE objTransporteBE)
        {
            try
            {
                //Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_GuardarProveedorYTransporte";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@Nom_Proveedor", objProveedorBE.Nom_Proveedor);
                cmd.Parameters.AddWithValue("@Direc_Proveedor", objProveedorBE.Direc_Proveedor);
                cmd.Parameters.AddWithValue("@RUC_Proveedor", objProveedorBE.RUC);
                cmd.Parameters.AddWithValue("@Telefono", objProveedorBE.Telefono);
                cmd.Parameters.AddWithValue("@Correo", objProveedorBE.Correo);
                cmd.Parameters.AddWithValue("@Usu_Registro", objProveedorBE.Usu_Registro);
                cmd.Parameters.AddWithValue("@Empresa_Transporte", objTransporteBE.Empresa_Transporte);
                cmd.Parameters.AddWithValue("@Direccion_Empresa", objTransporteBE.Direccion_Empresa);
                cmd.Parameters.AddWithValue("@Ruc_Transporte", objTransporteBE.Ruc_Transporte);
                cmd.Parameters.AddWithValue("@Marca_Transporte", objTransporteBE.Marca_Transporte);
                cmd.Parameters.AddWithValue("@Placa_Transporte", objTransporteBE.Placa_Transporte);
                cmd.Parameters.AddWithValue("@Licencia_Transporte", objTransporteBE.Licencia_Transporte);
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



















        public DataTable ListarNombreProveedor()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarNombreProveedores";
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

        public DataTable ListarProveedorActivos()
        {

            try
            {

                // Codifique
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ListarProveedorActivos";
                cmd.Parameters.Clear();
                DataSet dts = new DataSet();
                ada = new SqlDataAdapter(cmd);
                ada.Fill(dts, "Proveedores");
                return dts.Tables["Proveedores"];


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

        public DataTable ConsultarTransportistaxProveedor(String strIdCodigo)
        {

            try
            {
                //Codifique
                TransportistaBE objTransportistaBE = new TransportistaBE();

                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ProveedoresTransportePorIdProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdProveedor", strIdCodigo);
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

        public DataTable ConsultarProductoxProveedor(String strIdCodigo)
        {

            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "usp_ProveedoresProductosPorIdProveedor";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@IdProveedor", strIdCodigo);
                SqlDataAdapter miada;
                DataSet dts = new DataSet();
                miada = new SqlDataAdapter(cmd);
                miada.Fill(dts, "Productos");
                return dts.Tables["Productos"];


            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Boolean ActualizarProveedor(ProveedorBE objProveedorBE)
        {
            try
            {
                cnx.ConnectionString = MiConexion.GetCnx();
                cmd.Connection = cnx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_ActualizarProveedor";
                cmd.Parameters.Clear();
                //Agregamos parametros 
                cmd.Parameters.AddWithValue("@Id_Proveedor", objProveedorBE.Id_Proveedor);
                cmd.Parameters.AddWithValue("@Direc_Proveedor", objProveedorBE.Direc_Proveedor);
                cmd.Parameters.AddWithValue("@Telefono", objProveedorBE.Telefono);
                cmd.Parameters.AddWithValue("@Correo", objProveedorBE.Correo);
                cmd.Parameters.AddWithValue("@Estado", objProveedorBE.Estado);
                cmd.Parameters.AddWithValue("@Usu_Ult_Mod", objProveedorBE.Usu_Ult_Mod);

                //Codifique
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



    }
}
