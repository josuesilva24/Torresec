using System;
using System.Data.Common.CommandTrees;
using System.Linq;
using DATOS;

namespace DAL
{
    public class AlternativaDAL:DataAccessLogicBase
    {
        public IQueryable<Alternativa> GetAllAlternativas()
        {
            return DataContext.Alternativa;
        }

        public bool InsertAlternativa(Alternativa alternativa)
        {
            try
            {
                DataContext.AddToAlternativa(alternativa);
                DataContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
