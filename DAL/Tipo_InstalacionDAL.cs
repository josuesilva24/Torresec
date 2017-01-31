using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DATOS;

namespace DAL
{
    public class Tipo_InstalacionDAL:DataAccessLogicBase
    {
        public IQueryable<Tipo_Instalacion> GetAllTipo_Instalacion()
        {
            return DataContext.Tipo_Instalacion;
        }
    }
}
