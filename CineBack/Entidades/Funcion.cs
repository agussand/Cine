using System;

namespace CineBack.Entidades
{
    public class Funcion
    {
        public int FuncionId { get; set; }
        public Pelicula Pelicula { get; set; }
        public Sala oSala { get; set; }
        public string DiaMostrar { get; set; }
        public DateTime Dia {  get; set; }
        public string HoraMostrar { get; set; }
        public DateTime Hora { get; set; }

        public Funcion()
        {
            FuncionId = 0;
            Pelicula = new Pelicula();
            oSala = new Sala();
            DiaMostrar = string.Empty;
            Dia = DateTime.Now;
            HoraMostrar = string.Empty;
            Hora = DateTime.Now;
        }
        public Funcion(Pelicula pelicula, Sala sala)//Siempre una funcion va a tener una pelicula
        {
            FuncionId = 0;
            Pelicula = pelicula;
            oSala = sala;
            DiaMostrar = string.Empty;
            HoraMostrar = string.Empty;
        }
        public Funcion(int id, Pelicula pelicula, Sala sala, string dia, string hora)
        {
            FuncionId = id;
            Pelicula = pelicula;
            oSala = sala;
            DiaMostrar = dia;
            HoraMostrar = hora;
        }
    }
}