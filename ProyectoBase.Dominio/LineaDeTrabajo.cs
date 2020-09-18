namespace ProyectoBase.Dominio
{
    public class LineaDeTrabajo : EntityBase
    {
        public int Numero { get; set; }
        public override string ToString()
        {
            return Numero.ToString();
        }
    }
}