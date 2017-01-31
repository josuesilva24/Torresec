using System;
using System.Linq;
using Entity;

namespace DAL
{
    public class UsuarioDAL:DataAccessLogicBase
    {
        private IQueryable<Usuario> GetAllUsuario()
        {
            return DataContext.Usuarios;
        }
        public IQueryable<Usuario> GetUsuarioByNombreUsuario(string nombreUsuario)
        {
            return GetAllUsuario().Where(x => x.Nombre_Usuario.Equals(nombreUsuario, StringComparison.OrdinalIgnoreCase));
        }

    }
}
