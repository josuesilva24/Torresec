using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using DATOS;

namespace BussinesLogic
{
    public class Tipo_InstalacionBL
    {
        readonly Lazy<Tipo_InstalacionDAL> _tipoInstalacionLazy = new Lazy<Tipo_InstalacionDAL>(() => new Tipo_InstalacionDAL());
        Tipo_InstalacionDAL TipoInstalacionLazy { get { return _tipoInstalacionLazy.Value; } }

        public List<Tipo_Instalacion> GetAllTipo_Instalacion()
        {
            return TipoInstalacionLazy.GetAllTipo_Instalacion().ToList();
        }
    }
}
