using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaEntidad;
using CapaDatos;
using System.Data.SqlClient;
using System.Data;
using System.Linq.Expressions;
using System.Net.Http.Headers;

namespace CapaDatos
{
    public class CD_Negocio
    {
        public Negocio ObtenerDatos()
        {
            Negocio obj = new Negocio();

            //Realizamos la conexion a la bd
            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    string query = "select IdNegocio, Nombre, CUIT, Direccion from Negocio where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    //Mientras lee necesito que ejecute
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Negocio()
                            {
                                IdNegocio = int.Parse(dr["IdNegocio"].ToString()),
                                Nombre = dr["Nombre"].ToString(),
                                CUIT = dr["CUIT"].ToString(),
                                Direccion = dr["Direccion"].ToString()
                            };
                        }
                    }

                }
            }
            catch
            {
                obj = new Negocio();
            }
            return obj;
        }

        public bool GuardarDatos (Negocio objeto, out string mensaje)
        {
            mensaje = string.Empty;
            bool respuesta = true; 

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    //Hacemos un update de la tabla negocio
                    query.AppendLine("update Negocio set Nombre = @Nombre,");
                    query.AppendLine("CUIT = @CUIT,");
                    query.AppendLine("Direccion = @Direccion");
                    query.AppendLine("where IdNegocio = 1;");

                    //Enviamos los parametros
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                    cmd.Parameters.AddWithValue("@CUIT", objeto.CUIT);
                    cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                    cmd.CommandType = CommandType.Text;

                    //Validamos si la ejecución es correcta, nos devuelve el número de filas afectadas, si es menor de 1 nos da el error
                    //Nos devuelve el número de filas afectadas
                    if(cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo realizar el guardado de datos";
                        respuesta = false;

                    }

                   
                }
            }

            //Agregamos la excepcion
            catch(Exception ex) 
            {
                mensaje = ex.Message;
                respuesta = false;

            }
            return respuesta;
        }

        //Obtener logo
        public byte[] ObtenerLogo(out bool obtenido)
        {
            obtenido = true;
            byte[] logoByte = new byte[0];
            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    //Hacemos un select a la columna de logo
                    string query = "select Logo from Negocio where IdNegocio = 1";
                    SqlCommand cmd = new SqlCommand(query, conexion);
                    cmd.CommandType = CommandType.Text;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            //Casteamos el logo que trae un array a byte
                            logoByte = (byte[])dr["Logo"];
                        }
                    }


                }
            }
            catch (Exception ex)
            {
                obtenido =false;
                logoByte = new byte[0];

            }
            return logoByte;
        }

        //Actualizar elk logo

        public bool ActualizarLogo(byte[] image, out string mensaje){
            mensaje = string.Empty;
            bool respuesta = true;

            try
            {

                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    //Hacemos un update de la tabla negocio para la imagen
                    query.AppendLine("update Negocio set Logo = @imagen");
                    query.AppendLine("where IdNegocio = 1;");

                    //Enviamos los parametros
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@imagen", image);
                    cmd.CommandType = CommandType.Text;

                    //Validamos si la ejecución es correcta, nos devuelve el número de filas afectadas, si es menor de 1 nos da el error
                    //Nos devuelve el número de filas afectadas
                    if (cmd.ExecuteNonQuery() < 1)
                    {
                        mensaje = "No se pudo actualizar el logo";
                        respuesta = false;

                    }


                }
            }

            //Agregamos la excepcion
            catch (Exception ex)
            {
                mensaje = ex.Message;
                respuesta = false;

            }
            return respuesta;
        }


    }

 }

  
