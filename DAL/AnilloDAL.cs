using System.Linq;
using DATOS;

namespace DAL
{
    public class AnilloDAL:DataAccessLogicBase
    {
        public IQueryable<Anillo> GetAllAnillos()
        {
            return DataContext.Anillo;
        }

        }

    }
