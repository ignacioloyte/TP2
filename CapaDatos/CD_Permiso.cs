using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Permiso
    {

                public List<Permiso> Listar(int idusuario)
                {
                    List<Permiso> lista = new List<Permiso>();

                    using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                    {

                        try
                        {
                            StringBuilder query = new StringBuilder();
                            query.AppendLine("select p.IdRol, p.NombreMenu from Permisos as P");
                            query.AppendLine("inner join Rol R on r.IdRol = p.IdRol");
                            query.AppendLine("inner join Usuario u on u.IdRol = r.IdRol");
                            query.AppendLine("where u.IdUsuario = @idusuario");

                    
                            //Conectamos a la base de datos
                            SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                            cmd.Parameters.AddWithValue("@idusuario", idusuario);
                            cmd.CommandType = CommandType.Text;

                            oconexion.Open();

                            //Leemos la base de datos

                            using (SqlDataReader dr = cmd.ExecuteReader())
                            {
                                while (dr.Read())
                                {
                                    lista.Add(new Permiso()
                                    {
                                    oRol = new Rol() { IdRol = Convert.ToInt32(dr["IdRol"]) },
                                    NombreMenu = dr["NombreMenu"].ToString(),
                                });
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                         lista = new List<Permiso>();
                        
                        }
                    }

                    return lista;
                }
            }
    }

