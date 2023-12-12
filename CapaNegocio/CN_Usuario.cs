using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        //Instancia a nuestra clase instancia datos
        private CD_Usuario objcd_usuario = new CD_Usuario();

        //Retorna la lista de la clase usuario en la capa datos
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if(obj.NUsuario == "")
            {

                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el número de documento del usuario\n";
            }

            if (obj.Clave == "")
            {

                Mensaje += "Es necesario la contraseña del usuario\n";
            }

            if(Mensaje != string.Empty)
            {
                return 0;
            }
            else { 
            return objcd_usuario.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NUsuario == "")
            {

                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el número de documento del usuario\n";
            }

            if (obj.Clave == "")
            {

                Mensaje += "Es necesario la contraseña del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.NUsuario == "")
            {

                Mensaje += "Es necesario el nombre del usuario\n";
            }

            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el número de documento del usuario\n";
            }

            if (obj.Clave == "")
            {

                Mensaje += "Es necesario la contraseña del usuario\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_usuario.Eliminar(obj, out Mensaje);
            }
        }
    }
}

