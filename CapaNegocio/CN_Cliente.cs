using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        //Instancia a nuestra clase instancia datos
        private CD_Cliente objcd_Cliente = new CD_Cliente();

        //Retorna la lista de la clase Cliente en la capa datos
        public List<Cliente> Listar()
        {
            return objcd_Cliente.Listar();
        }

        public int Registrar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;


            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el número de documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {

                Mensaje += "Es necesario el Nombre Completo del Cliente\n";
            }

            if (obj.Email == "")
            {

                Mensaje += "Es necesario el email del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Cliente.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Cliente obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el número de documento del Cliente\n";
            }

            if (obj.NombreCompleto == "")
            {

                Mensaje += "Es necesario el Nombre Completo del Cliente\n";
            }

            if (obj.Email == "")
            {

                Mensaje += "Es necesario el email del Cliente\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Cliente.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Cliente obj, out string Mensaje)
        {
                return objcd_Cliente.Eliminar(obj, out Mensaje);
         
        }
    }
}
