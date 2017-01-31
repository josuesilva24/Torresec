using System.Linq;
using Entity;

namespace DAL
{
    public class AlternativaDAL:DataAccessLogicBase
    {
        public IQueryable<Alternativa> GetAllAlternativas()
        {
            return DataContext.Alternativas;
        }
    }
}
