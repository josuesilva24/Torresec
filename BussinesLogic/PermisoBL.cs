using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;


namespace BussinesLogic
{
    public class PermisoBL
    {
        readonly Lazy<DAL.PermisoDAL> _permisoLazy = new Lazy<PermisoDAL>(() => new PermisoDAL());
        PermisoDAL PermisoLazy { get { return _permisoLazy.Value; } }

        public List<Paquete_Permiso> GetAllAlternativas()
        {
            return PermisoLazy.GetAllPermisos().ToList();
        }
    }
}
