using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Usuario
    {
        public string User { get; set; }
        public string Pass { get; set; }
        public string Rol { get; set; }
        public Cliente Cliente { get; set; }

        public Usuario()
        {
            User = string.Empty;
            Pass = string.Empty;
            Rol = string.Empty;
            Cliente = new Cliente();
        }
    }
}
