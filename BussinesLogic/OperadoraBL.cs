using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;

namespace BussinesLogic
{
    public class OperadoraBL
    {
        readonly Lazy<OperadoraDAL> _operadoraLazy = new Lazy<OperadoraDAL>(() => new OperadoraDAL());
        OperadoraDAL OperadoraLazy { get { return _operadoraLazy.Value; } }

        public List<Operadora> GetAllAlternativas()
        {
            return OperadoraLazy.GetAllOperadoras().ToList();
        }
    }
}
