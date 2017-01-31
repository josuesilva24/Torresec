using System.Linq;
using Entity;

namespace DAL
{
    public class SitioDAL:DataAccessLogicBase
    {
        public IQueryable<Sitio> GetAllSitios()
        {
            return DataContext.Sitios;
        }
    }
}
