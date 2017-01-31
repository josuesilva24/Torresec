using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;

namespace BussinesLogic
{
    public class AlternativaBL
    {
        readonly Lazy<AlternativaDAL> _alternativaLazy = new Lazy<AlternativaDAL>(() => new AlternativaDAL());
        AlternativaDAL AlternativaLazy { get { return _alternativaLazy.Value; } }

        public List<Alternativa> GetAllAlternativas()
        {
            return AlternativaLazy.GetAllAlternativas().ToList();
        }
    }
}
