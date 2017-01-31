using System.Linq;
using DATOS;

namespace DAL
{
    public class SitioDAL:DataAccessLogicBase
    {
        public IQueryable<Sitio> GetAllSitios()
        {
            return DataContext.Sitio;
        }
    }
}
