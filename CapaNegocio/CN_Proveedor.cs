using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        //Instancia a nuestra clase instancia datos
        private CD_Proveedor objcd_Proveedor = new CD_Proveedor();

        //Retorna la lista de la clase Proveedor en la capa datos
        public List<Proveedor> Listar()
        {
            return objcd_Proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {

                Mensaje += "Es necesario la razón social del Proveedor\n";
            }

            if (obj.Email == "")
            {

                Mensaje += "Es necesario el email del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return 0;
            }
            else
            {
                return objcd_Proveedor.Registrar(obj, out Mensaje);
            }
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {

                Mensaje += "Es necesario la razón social del Proveedor\n";
            }

            if (obj.Email == "")
            {

                Mensaje += "Es necesario el email del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Editar(obj, out Mensaje);
            }
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {

                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {

                Mensaje += "Es necesario la razón social del Proveedor\n";
            }

            if (obj.Email == "")
            {

                Mensaje += "Es necesario el email del Proveedor\n";
            }

            if (Mensaje != string.Empty)
            {
                return false;
            }
            else
            {
                return objcd_Proveedor.Eliminar(obj, out Mensaje);
            }
        }

    }
}
