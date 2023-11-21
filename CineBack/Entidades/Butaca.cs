namespace CineBack.Entidades
{
    public enum Estado
    {
        Libre,
        Ocupado,
        Reservado
    }
    public class Butaca
    {
        public int NroButaca { get; set; }
        public string FilaCol { get; set; }
        public Estado Estado { get; set; } //Añadir una enum para que diga cualquiera de las 3 opciones

        public Butaca()
        {
            NroButaca = 0;
            Estado = Estado.Libre;
        }

        public Butaca(int nro, Estado estado)
        {
            NroButaca = nro;
            Estado = estado;
        }

        public override string ToString()
        {
            return NroButaca.ToString();    
        }
    }
}