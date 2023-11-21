namespace CineBack.Entidades
{
    public class Pelicula
    {
        public int IdPelicula { get; set; }
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Director { get; set; }
        public string Idioma { get; set; }
        public int Duracion { get; set; }
        public string Clasificacion { get; set; }
        public Pelicula()
        {
            IdPelicula = 0;
            Titulo = string.Empty;
            Genero = string.Empty;
            Director = string.Empty;
            Idioma = string.Empty;
            Duracion = 0;
            Clasificacion = string.Empty;
        }
        public Pelicula(int id, string tit, string gen, string dir, string idi, int dur, string clas)
        {
            IdPelicula = id;
            Titulo = tit;
            Genero = gen;
            Director = dir;
            Idioma = idi;
            Duracion = dur;
            Clasificacion = clas;
        }

        public override string ToString()
        {
            return Titulo;
        }
    }
}