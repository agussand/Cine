using CineBack.Datos.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Entrada
    {
        public int IdEntrada { get; set; }
        public Funcion Funcion { get; set; }
        public Butaca Butaca { get; set; }
        public Double Precio { get; set; }
        public int FormaPago { get; set; }

        public Entrada()
        {
            IdEntrada = 0;
            Butaca = new Butaca();
            FormaPago = 0;
            Precio = 1500;
        }

        public Entrada(int idEntrada, Funcion funcion, Butaca butaca, Double precio)
        {
            IdEntrada = idEntrada;
            Butaca = butaca;
            Precio = precio;
        }

        public Entrada(Butaca butaca)
        {
            Funcion = new Funcion();
            Butaca = butaca;
            FormaPago = 0;
            Precio = 1500;
        }
    }
}
