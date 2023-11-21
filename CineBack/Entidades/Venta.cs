using CineBack.Datos.Interfaz;
using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Entidades
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        //public Vendedor vendedor { get; set; }
        public Funcion Funcion { get; set; }
        public List<Entrada> lEntradas { get; set; }

        public Venta()
        {
            IdVenta = 0;
            Fecha = DateTime.Today;
            Funcion = new Funcion();
            lEntradas = new List<Entrada>();
        }

        public Venta(Cliente cliente)
        {
            IdVenta = 0;
            Fecha = DateTime.Today;
            Cliente = cliente;
            Funcion = new Funcion();
            lEntradas = new List<Entrada>();
        }

        public Double CalcularTotal()
        {
            double total = 0;
            foreach (Entrada e in lEntradas)
            {
                total += e.Precio;
            }
            return total;
        }

        public bool AgregarEntrada(Entrada entrada)
        {
            bool res = false;
            if (!lEntradas.Any<Entrada>(e => e.Butaca.NroButaca == entrada.Butaca.NroButaca))
            {
                lEntradas.Add(entrada);
                res = true;
            }
            return res;
        }

        public bool QuitarEntrada(Entrada entrada)
        {
            bool res = false;
            foreach (Entrada e in lEntradas)
            {
                if (e.Butaca.NroButaca == entrada.Butaca.NroButaca)
                {
                    lEntradas.Remove(e);
                    res = true;
                    break;
                }
            }
            return res;
        }

    }
}
