using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBase.Datos
{
    public class Contexto : DbContext, IQueryableUnitOfWork
    {
        public Contexto() : base("name=NombreBaseDeDatos")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
              .Conventions
              .Remove<PluralizingTableNameConvention>();

            modelBuilder
                .Conventions
                .Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder
                .Conventions
                .Remove<ManyToManyCascadeDeleteConvention>();

            //modelBuilder
            //    .Entity<Departament>()
            //    .ToTable("Departamentos");

            


            base.OnModelCreating(modelBuilder);
        }
        /*
         Aqui van los DbSet ej:
        public DbSet<Departament> Departaments { get; set; }
         */



        #region IQueryableUnitOfWork Miembros
        public void Confirmar()
        {
            try
            {
                base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                //Recupere los mensajes de error como una lista de cadenas.
                var errorMessages = ex.EntityValidationErrors
                    .SelectMany(x => x.ValidationErrors)
                    .Select(x => x.ErrorMessage);

                //Une la lista a una sola cadena.
                var fullErrorMessage = string.Join("; ", errorMessages);

                //Combine el mensaje de excepción original con el nuevo.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                //Lanza una nueva DbEntityValidationException con el mensaje de excepción mejorado.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        public void RevertirCambios()
        {
            //Asigna a todas las entidades en el change tracker (objeto encargado de mantener el estado de
            //cada objeto del contexto) el estado sin cambios (unchanged)
            base.ChangeTracker.Entries().Where(entry => entry.State != System.Data.Entity.EntityState.Added)
                .ToList()
                .ForEach(entry => entry.State = System.Data.Entity.EntityState.Unchanged);
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.State == EntityState.Added))
            {
                entry.State = EntityState.Detached;
            }
        }

        public DbSet<T> CrearSet<T>() where T : class
        {
            return base.Set<T>();
        }

        public void SetModificado<T>(T item) where T : class
        {
            base.Entry<T>(item).State = EntityState.Modified;
        }

        public void Refrescar<T>(T item) where T : class
        {
            //Recarga el objeto
            base.Entry<T>(item).Reload();
        }
        #endregion
    }
}
