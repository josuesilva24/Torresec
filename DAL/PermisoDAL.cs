using System.Linq;
using DATOS;


namespace DAL
{
    public class PermisoDAL:DataAccessLogicBase
    {
        public IQueryable<Paquete_Permiso> GetAllPermisos()
        {
            return DataContext.Paquete_Permiso;
        }
    }
}
