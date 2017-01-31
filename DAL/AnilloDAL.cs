using System.Linq;
using Entity;

namespace DAL
{
    public class AnilloDAL:DataAccessLogicBase
    {
        public IQueryable<Anillo> GetAllAnillos()
        {
            return DataContext.Anilloes;
        }

        }

    }
}
