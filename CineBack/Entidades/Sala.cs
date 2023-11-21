using System.Collections.Generic;

namespace CineBack.Entidades
{
    public class Sala
    {
        public enum Tipo_Sala
        {
            _2D, //las enumeraciones de C# no pueden comenzar con un número por eso el _
            _3D
        }
        public int IdSala { get; set; }
        public string TipoSala { get; set; }
        public List<Butaca> lButacas { get; set; }

        public Sala()
        {
            IdSala = 0;
            TipoSala = string.Empty;
            lButacas = new List<Butaca>();
        }
        public Sala(int idSala)
        {
            IdSala = idSala;
            TipoSala = string.Empty;
            lButacas = new List<Butaca>();
        }
        public Sala(int idSala, string tipoSala)
        {
            IdSala = idSala;
            TipoSala = tipoSala;
            lButacas = new List<Butaca>();
        }

        //public bool AgregarButaca(Butaca butaca)
        //{
        //    bool res = false;
        //    if (!lButacas.Any<Butaca>(b => b.NroButaca == butaca.NroButaca))
        //    {
        //        lButacas.Add(butaca);
        //        res = true;
        //    }
        //    return res;
        //}

        //public bool QuitarButaca(Butaca butaca)
        //{
        //    bool res = false;
        //    foreach (Butaca b in lButacas)
        //    {
        //        if (b.NroButaca == butaca.NroButaca)
        //        {
        //            lButacas.Remove(b);
        //            res = true;
        //            break;
        //        }
        //    }
        //    return res;
        //}
    }
}