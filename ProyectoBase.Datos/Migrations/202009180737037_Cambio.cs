namespace ProyectoBase.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cambio : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.LineaDeTrabajo", "Numero", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.LineaDeTrabajo", "Numero");
        }
    }
}
