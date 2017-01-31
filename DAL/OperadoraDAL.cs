using System.Linq;
using Entity;

namespace DAL
{
    public class OperadoraDAL : DataAccessLogicBase
    {
        public IQueryable<Operadora> GetAllOperadoras()
        {
            return DataContext.Operadoras;
        }
    }
}
