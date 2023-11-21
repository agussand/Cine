using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Interfaz
{
    public interface IClientesAplicacion
    {
        public bool RegistrarCliente(Usuario cliente);
        public bool UsuarioExistente(string usuario);
        public Usuario LogearCliente(string usuario, string pass);
    }
}
