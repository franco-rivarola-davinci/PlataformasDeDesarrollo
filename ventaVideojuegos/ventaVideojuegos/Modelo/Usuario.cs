using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ventaVideojuegos.Modelo
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
        public bool EsAdmin { get; set; }
    }
}
