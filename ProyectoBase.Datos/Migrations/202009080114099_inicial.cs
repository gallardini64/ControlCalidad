namespace ProyectoBase.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Color",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Defecto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pie = c.String(),
                        hora = c.DateTime(nullable: false),
                        especificacion_Id = c.Int(),
                        OrdenDeProduccion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EspecificacionDeDefecto", t => t.especificacion_Id)
                .ForeignKey("dbo.OrdenDeProduccion", t => t.OrdenDeProduccion_Id)
                .Index(t => t.especificacion_Id)
                .Index(t => t.OrdenDeProduccion_Id);
            
            CreateTable(
                "dbo.EspecificacionDeDefecto",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        Tipo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Empleado",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Documento = c.Int(nullable: false),
                        Apellido_Nombre = c.String(),
                        Email = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LineaDeTrabajo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Modelo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SKU = c.Int(nullable: false),
                        Denominacion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OrdenDeProduccion",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.Int(nullable: false),
                        Fecha = c.DateTime(nullable: false),
                        Estado = c.String(),
                        Color_Id = c.Int(),
                        LineaDeTrabajo_Id = c.Int(),
                        Modelo_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Color", t => t.Color_Id)
                .ForeignKey("dbo.LineaDeTrabajo", t => t.LineaDeTrabajo_Id)
                .ForeignKey("dbo.Modelo", t => t.Modelo_Id)
                .Index(t => t.Color_Id)
                .Index(t => t.LineaDeTrabajo_Id)
                .Index(t => t.Modelo_Id);
            
            CreateTable(
                "dbo.Par",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Hora = c.DateTime(nullable: false),
                        Calidad = c.String(),
                        OrdenDeProduccion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrdenDeProduccion", t => t.OrdenDeProduccion_Id)
                .Index(t => t.OrdenDeProduccion_Id);
            
            CreateTable(
                "dbo.Periodo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cantidadDeHorasOcupadas = c.Int(nullable: false),
                        Turno_Id = c.Int(),
                        OrdenDeProduccion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turno", t => t.Turno_Id)
                .ForeignKey("dbo.OrdenDeProduccion", t => t.OrdenDeProduccion_Id)
                .Index(t => t.Turno_Id)
                .Index(t => t.OrdenDeProduccion_Id);
            
            CreateTable(
                "dbo.Turno",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Inicio = c.DateTime(nullable: false),
                        Fin = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Periodo", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion");
            DropForeignKey("dbo.Periodo", "Turno_Id", "dbo.Turno");
            DropForeignKey("dbo.Par", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion");
            DropForeignKey("dbo.OrdenDeProduccion", "Modelo_Id", "dbo.Modelo");
            DropForeignKey("dbo.OrdenDeProduccion", "LineaDeTrabajo_Id", "dbo.LineaDeTrabajo");
            DropForeignKey("dbo.Defecto", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion");
            DropForeignKey("dbo.OrdenDeProduccion", "Color_Id", "dbo.Color");
            DropForeignKey("dbo.Defecto", "especificacion_Id", "dbo.EspecificacionDeDefecto");
            DropIndex("dbo.Periodo", new[] { "OrdenDeProduccion_Id" });
            DropIndex("dbo.Periodo", new[] { "Turno_Id" });
            DropIndex("dbo.Par", new[] { "OrdenDeProduccion_Id" });
            DropIndex("dbo.OrdenDeProduccion", new[] { "Modelo_Id" });
            DropIndex("dbo.OrdenDeProduccion", new[] { "LineaDeTrabajo_Id" });
            DropIndex("dbo.OrdenDeProduccion", new[] { "Color_Id" });
            DropIndex("dbo.Defecto", new[] { "OrdenDeProduccion_Id" });
            DropIndex("dbo.Defecto", new[] { "especificacion_Id" });
            DropTable("dbo.Turno");
            DropTable("dbo.Periodo");
            DropTable("dbo.Par");
            DropTable("dbo.OrdenDeProduccion");
            DropTable("dbo.Modelo");
            DropTable("dbo.LineaDeTrabajo");
            DropTable("dbo.Empleado");
            DropTable("dbo.EspecificacionDeDefecto");
            DropTable("dbo.Defecto");
            DropTable("dbo.Color");
        }
    }
}
