namespace ProyectoBase.Dominio
{
    public class Periodo : EntityBase
    {
        public int Id { get; set; }
        public int cantidadDeHorasOcupadas { get; set; }
        public Turno Turno { get; set; }
    }
}