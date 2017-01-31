using System.Linq;
using Entity;

namespace DAL
{
    public class EnergiaDAL : DataAccessLogicBase
    {
        public IQueryable<Energia> GetAllAnillos()
        {
            return DataContext.Energias;
        }
    }
}
