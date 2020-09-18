namespace ProyectoBase.Dominio
{
    public class Modelo : EntityBase
    {
        public int SKU { get; set; }
        public string Denominacion { get; set; }

        public override string ToString()
        {
            return Denominacion;
        }
    }
}