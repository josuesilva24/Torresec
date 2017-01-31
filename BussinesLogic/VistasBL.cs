using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using MapSource;

namespace BussinesLogic
{
    public class VistasBL
    {
        readonly Lazy<VistasDAL> _vistasDAL = new Lazy<VistasDAL>(() => new VistasDAL());
        VistasDAL VistasDAL { get { return _vistasDAL.Value; } }

        public List<MapSource.Vistas> GetVistasListByUsuario(string nombreUsuario)
        {
            var usuarioVistas = VistasDAL.GetAllVistaByusuario(nombreUsuario).ToList();
            return usuarioVistas.Select(usuarioVista => new MapSource.Vistas
            {
                Id = usuarioVista.Id_Vista, Escritura = usuarioVista.Escritura, Lectura = usuarioVista.Lectura, Vista = usuarioVista.Vistas.Vista
            }).ToList();
        }
    }
}
