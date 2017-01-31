using System.Linq;
using DATOS;

namespace DAL
{
    public class EnergiaDAL : DataAccessLogicBase
    {
        public IQueryable<Energia> GetAllAnillos()
        {
            return DataContext.Energia;
        }
    }
}
