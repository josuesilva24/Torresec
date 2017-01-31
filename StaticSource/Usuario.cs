using System.Collections.Generic;

namespace MapSource
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public List<Vistas> Vistas { get; set; }
    }
}
