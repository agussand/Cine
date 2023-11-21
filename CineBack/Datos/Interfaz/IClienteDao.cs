using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Interfaz
{
    internal interface IClienteDao
    {
        public bool RegistrarCliente(Usuario cliente);
        //public bool EliminarCliente(Cliente cliente);
        public bool UsuarioExistente(string usuario);

        public Usuario LogearCliente(string usuario, string contraseña);
    }
}
