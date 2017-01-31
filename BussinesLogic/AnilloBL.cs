using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;

namespace BussinesLogic
{
    public class AnilloBL
    {
        readonly Lazy<AnilloDAL> _anilloLazy = new Lazy<AnilloDAL>(() => new AnilloDAL());
        AnilloDAL AlternativaLazy { get { return _anilloLazy.Value; } }

        public List<Anillo> GetAllAlternativas()
        {
            return AlternativaLazy.GetAllAnillos().ToList();
        }
    }
}
