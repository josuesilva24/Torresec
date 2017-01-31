using System.Collections.Generic;
using System.Linq;
using Entity;

namespace DAL
{
    public class VistasDAL:DataAccessLogicBase
    {
        public IQueryable<Vista> GetAllVista()
        {
            return DataContext.Vistas;
        }
        private IQueryable<Usuario_Vista> GetAllUsuario_Vista()
        {
            return DataContext.Usuario_Vista;
        }
        public IQueryable<Vista> GetAllVistaById(int id)
        {
            return GetAllVista().Where(x => x.Id.Equals(id));
        }
        public IQueryable<Usuario_Vista> GetAllVistaByusuario(string nombreUsuario)
        {
            return GetAllUsuario_Vista().Where(x => x.Nombre_Usuario.Equals(nombreUsuario));
        }
    }
}
