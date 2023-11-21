using CineBack.Datos.Implementacion;
using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using CineBack.Fachada.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Implementacion
{
    public class ClientesAplicacion : IClientesAplicacion
    {
        private IClienteDao clienteDao;

        public ClientesAplicacion()
        {
            clienteDao = new ClienteDao();
        }

        public Usuario LogearCliente(string usuario, string pass)
        {
            return clienteDao.LogearCliente(usuario, pass);
        }

        public bool RegistrarCliente(Usuario cliente)
        {
            return clienteDao.RegistrarCliente(cliente);
        }

        public bool UsuarioExistente(string usuario)
        {
            return clienteDao.UsuarioExistente(usuario);
        }
    }
}
