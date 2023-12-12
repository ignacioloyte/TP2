using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        //Instancia a nuestra clase instancia datos
        private CD_Permiso objcd_permiso = new CD_Permiso();

        //Retorna la lista de la clase usuario en la capa datos
        public List<Permiso> Listar(int IdUsuario)
        {
            return objcd_permiso.Listar(IdUsuario);
        }
    }
}
