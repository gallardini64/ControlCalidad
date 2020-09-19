namespace ProyectoBase.Dominio
{
    public class Periodo : EntityBase
    {
        public int cantidadDeHorasOcupadas { get; set; }
        public virtual Turno Turno { get; set; }
        public Periodo()
        {

        }
        public Periodo(Turno turno)
        {
            Turno = turno;
        }
    }
}