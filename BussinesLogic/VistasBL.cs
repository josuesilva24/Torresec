using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using Entity;
using MapSource;

namespace BussinesLogic
{
    public class VistasBL
    {
        readonly Lazy<VistasDAL> _vistasDAL = new Lazy<VistasDAL>(() => new VistasDAL());
        VistasDAL VistasDAL { get { return _vistasDAL.Value; } }

        public List<Vistas> GetVistasListByUsuario(string nombreUsuario)
        {
            var usuarioVistas = VistasDAL.GetAllVistaByusuario(nombreUsuario).ToList();
            return usuarioVistas.Select(usuarioVista => new Vistas
            {
                Id = usuarioVista.Id_Vista, Escritura = usuarioVista.Escritura, Lectura = usuarioVista.Lectura, Vista = usuarioVista.Vista.Vista1
            }).ToList();
        }
    }
}
