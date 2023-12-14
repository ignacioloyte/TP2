using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using CapaEntidad;
using System.Reflection;
using System.Collections;
using System.Security.Claims;

namespace CapaDatos
{
    public class CD_Usuario
    {


        public List<Usuario> Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                
                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select u.IdUsuario, u.NUsuario, u.NroDocumento, u.NombreCompleto, u.Email, u.FechaAlta, u.FechaBaja, u.Clave, r.IdRol, r.Descripcion,u.estado ");
                    query.AppendLine("from Usuario u inner join rol r on r.IdRol = u.IdRol");
                        
                        
                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    //Leemos la base de datos

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Usuario()
                            {
                                IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                                NUsuario = dr["NUsuario"].ToString(),
                                Documento = dr["NroDocumento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                Email = dr["Email"] != DBNull.Value ? dr["Email"].ToString() : null,
                                FechaAlta = Convert.ToDateTime(dr["FechaAlta"]),
                                FechaBaja = dr["FechaBaja"] != DBNull.Value ? Convert.ToDateTime(dr["FechaBaja"]) : new DateTime(2100, 1, 1),
                                Clave = dr["Clave"].ToString(),
                                Estado = Convert.ToBoolean(dr["Estado"]),
                                rol = dr["Descripcion"].ToString(),
                                oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]), Descripcion  = dr["Descripcion"].ToString() }
                            
                            });
                        }
                    }

                }catch (Exception ex)
                {
                    throw;
                }
            }

            return lista;
        }

        // Levantamos los SP de Registrar, Editar y eliminar usuario

        public int Registrar(Usuario obj, out string Mensaje)
        {
            int idUsuarioGenerado = 0;
            Mensaje =string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand("SP_REGISTRARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("NUsuario", obj.NUsuario);
                    cmd.Parameters.AddWithValue("NroDocumento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("FechaAlta", obj.FechaAlta);
                    cmd.Parameters.AddWithValue("FechaBaja", obj.FechaAlta);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("IdUsuarioResultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    idUsuarioGenerado = Convert.ToInt32(cmd.Parameters["IdUsuarioResultado"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                idUsuarioGenerado = 0;
                Mensaje = ex.Message;
            }

            return idUsuarioGenerado;


        }


        public bool Editar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand("SP_EDITARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.AddWithValue("NUsuario", obj.NUsuario);
                    cmd.Parameters.AddWithValue("NroDocumento", obj.Documento);
                    cmd.Parameters.AddWithValue("NombreCompleto", obj.NombreCompleto);
                    cmd.Parameters.AddWithValue("Email", obj.Email);
                    cmd.Parameters.AddWithValue("FechaAlta", obj.FechaAlta);
                    cmd.Parameters.AddWithValue("FechaBaja", obj.FechaAlta);
                    cmd.Parameters.AddWithValue("Clave", obj.Clave);
                    cmd.Parameters.AddWithValue("IdRol", obj.oRol.IdRol);
                    cmd.Parameters.AddWithValue("Estado", obj.Estado);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                Respuesta = false; 
                Mensaje = ex.Message;
            }

            return Respuesta;


        }


        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            bool Respuesta = false;
            Mensaje = string.Empty;


            try
            {
                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {

                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand("SP_ELIMINARUSUARIO", oconexion);
                    cmd.Parameters.AddWithValue("IdUsuario", obj.IdUsuario);
                    cmd.Parameters.Add("Respuesta", SqlDbType.Int).Direction = ParameterDirection.Output;
                    cmd.Parameters.Add("Mensaje", SqlDbType.VarChar,500).Direction = ParameterDirection.Output;
                    cmd.CommandType = CommandType.StoredProcedure;

                    oconexion.Open();

                    cmd.ExecuteNonQuery();

                    Respuesta = Convert.ToBoolean(cmd.Parameters["Respuesta"].Value);
                    Mensaje = cmd.Parameters["Mensaje"].Value.ToString();

                }

            }
            catch (Exception ex)
            {
                Respuesta = false;
                Mensaje = ex.Message;
            }

            return Respuesta;


        }

        public void IncrementarIntentosFallidos(int usuarioId)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                string consultaIncremento = "UPDATE Usuario SET intentos = intentos + 1 WHERE IDUsuario = @usuarioId";

                using (SqlCommand comando = new SqlCommand(consultaIncremento, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@usuarioId", SqlDbType.Int));
                    comando.Parameters["@usuarioId"].Value = usuarioId;

                    comando.ExecuteNonQuery();
                }

                // Comprobar si el número de intentos ha alcanzado 3 y actualizar el estado
                string consultaVerificacion = "SELECT intentos FROM Usuario WHERE IdUsuario = @usuarioId";
                using (SqlCommand comandoVerificacion = new SqlCommand(consultaVerificacion, conexion))
                {
                    comandoVerificacion.Parameters.Add(new SqlParameter("@usuarioId", SqlDbType.Int));
                    comandoVerificacion.Parameters["@usuarioId"].Value = usuarioId;

                    int intentos = (int)comandoVerificacion.ExecuteScalar();
                    if (intentos >= 3)
                    {
                        string consultaEstado = "UPDATE Usuario SET estado = 0 WHERE IdUsuario = @usuarioId";
                        using (SqlCommand comandoEstado = new SqlCommand(consultaEstado, conexion))
                        {
                            comandoEstado.Parameters.Add(new SqlParameter("@usuarioId", SqlDbType.Int));
                            comandoEstado.Parameters["@usuarioId"].Value = usuarioId;

                            comandoEstado.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        // Enum para representar el resultado de la verificación de credenciales
        public enum ResultadoVerificacion
        {
            UsuarioNoExiste,
            ContraseñaIncorrecta,
            CredencialesCorrectas,
            UsuarioBloqueado
        }

        public ResultadoVerificacion VerificarCredenciales(string nusuario, string clave)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                // Modificar la consulta para incluir también el estado del usuario
                string consulta = "SELECT clave, estado FROM Usuario WHERE Nusuario = @nusuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@nusuario", SqlDbType.NVarChar));
                    comando.Parameters["@nusuario"].Value = nusuario;

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (!reader.HasRows)
                        {
                            return ResultadoVerificacion.UsuarioNoExiste;
                        }
                        else
                        {
                            reader.Read();
                            int estado = Convert.ToInt32(reader["estado"]);
                            if (estado == 0)
                            {
                                return ResultadoVerificacion.UsuarioBloqueado;
                            }

                            string claveEncontrada = reader["clave"].ToString();
                            if (Encriptado.ValidatePassword(clave, claveEncontrada))
                            {
                                return ResultadoVerificacion.CredencialesCorrectas;
                            }
                            else
                            {
                                return ResultadoVerificacion.ContraseñaIncorrecta;
                            }
                        }
                    }
                }
            }
        }
        public int ObtenerIdUsuario(string nombreUsuario)
        {
            int usuarioId = -1; // Valor predeterminado que indica que no se encontró el usuario

            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                string consulta = "SELECT IdUsuario FROM Usuario WHERE Nusuario = @nombreUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                    object resultado = comando.ExecuteScalar();
                    if (resultado != null)
                    {
                        usuarioId = Convert.ToInt32(resultado);
                    }
                }
            }

            return usuarioId;
        }
    

    public void ReiniciarIntentosFallidos(int usuarioId)
        {
            using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
            {
                conexion.Open();
                string consulta = "UPDATE Usuario SET intentos = 0 WHERE IdUsuario = @usuarioId";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("@usuarioId", SqlDbType.Int));
                    comando.Parameters["@usuarioId"].Value = usuarioId;

                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
