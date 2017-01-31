using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;

namespace BussinesLogic
{
    public class SitioBL
    {
        readonly Lazy<SitioDAL> _sitioLazy = new Lazy<SitioDAL>(() => new SitioDAL());
        SitioDAL SitioLazy { get { return _sitioLazy.Value; } }

        public List<Sitio> GetAllAlternativas()
        {
            return SitioLazy.GetAllSitios().ToList();
        }
    }
}
