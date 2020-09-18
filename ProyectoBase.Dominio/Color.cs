namespace ProyectoBase.Dominio
{
    public class Color : EntityBase
    {
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}