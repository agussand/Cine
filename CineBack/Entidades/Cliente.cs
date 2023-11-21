using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public enum Tipos_Cliente
    {
        Niño = 1,
        Joven,
        Adulto,
        Jubilado
    }
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni {  get; set; }
        public string Contacto { get; set; }

        public Tipos_Cliente TipoCliente { get; set; }

        public Cliente()
        {
            IdCliente = 0;
            Nombre = string.Empty;
            Apellido = string.Empty;
            Dni = 0;
            Contacto = string.Empty;
            TipoCliente = Tipos_Cliente.Niño;
        }
    }
}
