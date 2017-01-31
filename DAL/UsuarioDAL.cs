using System;
using System.Linq;
using DATOS;

namespace DAL
{
    public class UsuarioDAL:DataAccessLogicBase
    {
        private IQueryable<Usuario> GetAllUsuario()
        {
            return DataContext.Usuario;
        }
        public IQueryable<Usuario> GetUsuarioByNombreUsuario(string nombreUsuario)
        {
            return GetAllUsuario().Where(x => x.Nombre_Usuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
        }

    }
}
