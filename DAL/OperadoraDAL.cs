using System.Linq;
using DATOS;


namespace DAL
{
    public class OperadoraDAL : DataAccessLogicBase
    {
        public IQueryable<Operadora> GetAllOperadoras()
        {
            return DataContext.Operadora;
        }
    }
}
