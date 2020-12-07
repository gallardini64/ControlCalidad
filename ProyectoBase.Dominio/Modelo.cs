namespace ProyectoBase.Dominio
{
    public class Modelo : EntityBase
    {
        public int SKU { get; set; }
        public string Denominacion { get; set; }
        public int Objetivo { get; set; }
        public override string ToString()
        {
            return Denominacion;
        }
        public Modelo()
        {

        }
        public Modelo(int sku, string denominacion)
        {
            SKU = sku;
            Denominacion = denominacion;
        }
    }
}