using CineBack.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineBack.Datos.Interfaz
{
    public interface IFuncionDao
    {
        List<Funcion> GetFunciones(int id_pelicula);//Devuelve las funciones según la película enviada por parametro
        List<Pelicula> GetPeliculas(); //Mapea peliculas para cargar el combo
        List<Butaca> GetButacas(int id_sala, int id_funcion); //Trae lista de butacas de la sala ingresada por parametro
        bool CrearFuncion(Funcion funcion);
        bool ButacasDisponibles(int id_funcion, int cantidad);
        bool ConfirmarVenta(Venta venta);
        //bool ConfirmarNuevaFuncion(Funcion funcion);
    }
}
