using CapaEntidad;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using System.Linq.Expressions;

namespace CapaDatos
{
    public class CD_Compra
    {

        public int ObtenerCorrelativo()
        {

            int idCorrelativo = 0;


            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena)){

                try
                {

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) +1  from Compra");

                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    //Devuelve de la primera columna, la primera fila
                    idCorrelativo = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch (Exception ex)
                {
                    idCorrelativo = 0;

                }

            }

            return idCorrelativo;

        }

            public bool Registrar(Compra obj, DataTable DetalleCompra, out string Mensaje){
                bool Respuesta = false;
                Mensaje = string.Empty;

                using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
                {
                    try
                    { //Conectamos a la base de datos
                        SqlCommand cmd = new SqlCommand("SP_REGISTRARCOMPRA", oconexion);
                        cmd.Parameters.AddWithValue("IdUsuario", obj.oUsuario.IdUsuario);
                        cmd.Parameters.AddWithValue("IdProveedor", obj.oProveedor.IdProveedor);
                        cmd.Parameters.AddWithValue("TipoDocumento", obj.TipoDocumento);
                        cmd.Parameters.AddWithValue("NumeroDocumento", obj.NumeroDocumento);
                        cmd.Parameters.AddWithValue("MontoTotal", obj.MontoTotal);
                        cmd.Parameters.AddWithValue("DetalleCompra", DetalleCompra);
                        cmd.Parameters.Add("Resultado", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Parameters.Add("Mensaje", SqlDbType.VarChar, 500).Direction = ParameterDirection.Output;
                        cmd.CommandType = CommandType.StoredProcedure;

                        oconexion.Open();
                        cmd.ExecuteNonQuery();

                        

                        Respuesta = Convert.ToBoolean(cmd.Parameters["Resultado"].Value);
                        Mensaje = cmd.Parameters["Mensaje"].Value.ToString();



                    }
                    catch (Exception ex)
                    {
                        Respuesta = false;
                        Mensaje = ex.Message;

                    }


                }
                return Respuesta;
            }

        public Compra ObtenerCompra(string numero)
        {
            Compra obj = new Compra();

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {

                try
                {

                    StringBuilder query = new StringBuilder();


                    query.AppendLine("select c.IdCompra,u.NombreCompleto,p.Documento,p.RazonSocial,");
                    query.AppendLine("c.TipoDocumento,c.NumeroDocumento,c.MontoTotal,");
                    query.AppendLine("convert(char(10), c.FechaCreacion, 103)[FechaRegistro]");
                    query.AppendLine("from Compra C inner join Usuario U on U.IdUsuario = C.IdUsuario");
                    query.AppendLine("inner join Proveedor p on p.IdProveedor = C.IdProveedor");
                    query.AppendLine("where c.NumeroDocumento = @numero");



                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand(query.ToString(), oconexion);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.CommandType = CommandType.Text;

                    oconexion.Open();

                    //Leemos la base de datos

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Compra()
                            {
                                IdCompra = Convert.ToInt32(dr["IdCompra"]),
                                oUsuario = new Usuario() { NombreCompleto = dr["NombreCompleto"].ToString()},
                                oProveedor = new Proveedor() { Documento = dr["Documento"].ToString(), RazonSocial = dr["RazonSocial"].ToString() },
                                TipoDocumento = dr["TipoDocumento"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString()),
                                FechaCreacion = Convert.ToDateTime(dr["FechaRegistro"].ToString())
                            };
                            

                        }
                    }

                }
                catch (Exception ex)
                {
                    obj = new Compra();
                }
            }


            return obj;

        }

        //Detalle Compra

        public List<DetalleCompra> ObtenerDetalleCompra(int IdCompra)
        {
            List<DetalleCompra> oLista = new List<DetalleCompra>();
            try
            {
                using (SqlConnection conexion = new SqlConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select p.Nombre,dc.PrecioCompra, dc.Cantidad, dc.MontoTotal");
                    query.AppendLine("from Detalle_compra dc inner join producto p on p.IdProducto = dc.IdProducto where dc.IdCompra = @IdCompra");

                    //Conectamos a la base de datos
                    SqlCommand cmd = new SqlCommand(query.ToString(), conexion);
                    cmd.Parameters.AddWithValue("@IdCompra", IdCompra);
                    cmd.CommandType = System.Data.CommandType.Text;

                    //Leemos la base de datos

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleCompra()
                            {
                                
                                oProducto = new Producto() {Nombre = dr["Nombre"].ToString() },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"].ToString()),
                                Cantidad = Convert.ToInt32(dr["Cantidad"].ToString()),
                                MontoTotal = Convert.ToDecimal(dr["MontoTotal"].ToString())
                            });
                        }
                    }

                }
               
            }
            catch (Exception ex)
            {
                oLista = new List<DetalleCompra>();
            }

            return oLista;



        
        }

    }
}



