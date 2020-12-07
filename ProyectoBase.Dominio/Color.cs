namespace ProyectoBase.Dominio
{
    public class Color : EntityBase
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
        public Color()
        {

        }
        public Color(int codigo, string descripcion)
        {
            Codigo = codigo;
            Descripcion = descripcion;
        }
    }
}