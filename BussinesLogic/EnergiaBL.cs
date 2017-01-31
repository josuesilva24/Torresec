using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;

namespace BussinesLogic
{
    public class EnergiaBL
    {
        readonly Lazy<EnergiaDAL> _energiaLazy = new Lazy<EnergiaDAL>(() => new EnergiaDAL());
        EnergiaDAL EnergiaLazy { get { return _energiaLazy.Value; } }

        public List<Energia> GetAllAlternativas()
        {
            return EnergiaLazy.GetAllAnillos().ToList();
        }
    }
}
