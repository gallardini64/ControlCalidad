namespace ProyectoBase.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Cambio2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Defecto", "hora", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.OrdenDeProduccion", "Fecha", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Par", "Hora", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Turno", "Inicio", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Turno", "Fin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Turno", "Fin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Turno", "Inicio", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Par", "Hora", c => c.DateTime(nullable: false));
            AlterColumn("dbo.OrdenDeProduccion", "Fecha", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Defecto", "hora", c => c.DateTime(nullable: false));
        }
    }
}
