using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.ComponentModel;

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

        private CD_Usuario cdUsuario;

        public CN_Usuario(CD_Usuario cdUsuario)
        {
            this.cdUsuario = cdUsuario;
        }

        public CN_Usuario( )
        {
           
            
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
       

        public bool IntentarInicioSesion(string nombreUsuario, string contraseña)
        {
            var resultado = objcd_usuario.VerificarCredenciales(nombreUsuario, contraseña);

            switch (resultado)
            {
                case CD_Usuario.ResultadoVerificacion.CredencialesCorrectas:
                    // Lógica adicional...
                    ReiniciarIntentosFallidos(nombreUsuario);
                    return true;

                case CD_Usuario.ResultadoVerificacion.UsuarioNoExiste:
                    // Lógica para usuario no existente...
                    return false;

                case CD_Usuario.ResultadoVerificacion.ContraseñaIncorrecta:
                    // Lógica para contraseña incorrecta...
                    IncrementarIntentosFallidos(nombreUsuario);
                    return false;

                case CD_Usuario.ResultadoVerificacion.UsuarioBloqueado:
                    // Lógica para contraseña incorrecta...
                
                    return false;

                default:
                    // Lógica para otros casos...
                    return false;
            }
        }

        private void IncrementarIntentosFallidos(string nombreUsuario)
    {
        // Obtener el ID del usuario basado en su nombre de usuario.
        int usuarioId = objcd_usuario.ObtenerIdUsuario(nombreUsuario);
        if (usuarioId > 0)
        {
            objcd_usuario.IncrementarIntentosFallidos(usuarioId);
        }
    }

        public void ReiniciarIntentosFallidos(string nombreUsuario)
    {
        int usuarioId = objcd_usuario.ObtenerIdUsuario(nombreUsuario);
        if (usuarioId > 0)
        {
                objcd_usuario.ReiniciarIntentosFallidos(usuarioId);
        }
    }
     

    }
}

