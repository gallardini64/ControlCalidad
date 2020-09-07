namespace ProyectoBase.Dominio
{
    public class EspecificacionDeDefecto : EntityBase
    {
        public string descripcion { get; set; }
        
        private Tipo tipo;

        public string Tipo  
        {
            set
            {
                if (value == "Observado")
                {
                    this.tipo = Dominio.Tipo.Observado;
                }
                else
                {
                    this.tipo = Dominio.Tipo.Reprocesado;
                }
            }
            get
            {
                return tipo.ToString();
            }
        }
    }
}