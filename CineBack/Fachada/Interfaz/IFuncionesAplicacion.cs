using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Fachada.Interfaz
{
    public interface IFuncionesAplicacion
    {
        bool ConfirmarVenta(Venta venta);
        List<Pelicula> GetPeliculas();
        List<Funcion> GetFunciones(int pelicula);
        List<Butaca> GetButacas(int id_sala, int id_funcion);
        bool ButacasDisponibles(int id_funcion, int cantidad);
        bool CrearFuncion(Funcion funcion);
    }
}
