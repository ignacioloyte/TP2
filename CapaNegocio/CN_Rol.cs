using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;



namespace CapaNegocio
{
    public class CN_Rol
    {
        //Instancia a nuestra clase instancia datos
        private CD_Rol objcd_rol = new CD_Rol();

        //Retorna la lista de la clase usuario en la capa datos
        public List<Rol> Listar()
        {
            return objcd_rol.Listar();
        }
    }
}
