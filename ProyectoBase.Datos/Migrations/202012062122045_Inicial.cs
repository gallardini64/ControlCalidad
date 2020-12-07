namespace ProyectoBase.Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Defecto", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion");
            DropForeignKey("dbo.Par", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion");
            DropForeignKey("dbo.Periodo", "Turno_Id", "dbo.Turno");
            DropForeignKey("dbo.Periodo", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion");
            DropIndex("dbo.Defecto", new[] { "OrdenDeProduccion_Id" });
            DropIndex("dbo.Par", new[] { "OrdenDeProduccion_Id" });
            DropIndex("dbo.Periodo", new[] { "Turno_Id" });
            DropIndex("dbo.Periodo", new[] { "OrdenDeProduccion_Id" });
            CreateTable(
                "dbo.Horario",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CantidadDeHorasOcupadas = c.Int(nullable: false),
                        Inicio = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Fin = c.DateTime(nullable: false, precision: 7, storeType: "datetime2"),
                        Turno_Id = c.Int(),
                        OrdenDeProduccion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Turno", t => t.Turno_Id)
                .ForeignKey("dbo.OrdenDeProduccion", t => t.OrdenDeProduccion_Id)
                .Index(t => t.Turno_Id)
                .Index(t => t.OrdenDeProduccion_Id);
            
            AddColumn("dbo.Color", "Codigo", c => c.Int(nullable: false));
            AddColumn("dbo.Defecto", "Horario_Id", c => c.Int());
            AddColumn("dbo.Modelo", "Objetivo", c => c.Int(nullable: false));
            AddColumn("dbo.OrdenDeProduccion", "HorarioActual_Id", c => c.Int());
            AddColumn("dbo.Par", "Horario_Id", c => c.Int());
            AlterColumn("dbo.Turno", "Inicio", c => c.Int(nullable: false));
            AlterColumn("dbo.Turno", "Fin", c => c.Int(nullable: false));
            CreateIndex("dbo.Defecto", "Horario_Id");
            CreateIndex("dbo.OrdenDeProduccion", "HorarioActual_Id");
            CreateIndex("dbo.Par", "Horario_Id");
            AddForeignKey("dbo.Defecto", "Horario_Id", "dbo.Horario", "Id");
            AddForeignKey("dbo.Par", "Horario_Id", "dbo.Horario", "Id");
            AddForeignKey("dbo.OrdenDeProduccion", "HorarioActual_Id", "dbo.Horario", "Id");
            DropColumn("dbo.Defecto", "OrdenDeProduccion_Id");
            DropColumn("dbo.Par", "OrdenDeProduccion_Id");
            DropTable("dbo.Periodo");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Periodo",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        cantidadDeHorasOcupadas = c.Int(nullable: false),
                        Turno_Id = c.Int(),
                        OrdenDeProduccion_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Par", "OrdenDeProduccion_Id", c => c.Int());
            AddColumn("dbo.Defecto", "OrdenDeProduccion_Id", c => c.Int());
            DropForeignKey("dbo.Horario", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion");
            DropForeignKey("dbo.OrdenDeProduccion", "HorarioActual_Id", "dbo.Horario");
            DropForeignKey("dbo.Horario", "Turno_Id", "dbo.Turno");
            DropForeignKey("dbo.Par", "Horario_Id", "dbo.Horario");
            DropForeignKey("dbo.Defecto", "Horario_Id", "dbo.Horario");
            DropIndex("dbo.Par", new[] { "Horario_Id" });
            DropIndex("dbo.Horario", new[] { "OrdenDeProduccion_Id" });
            DropIndex("dbo.Horario", new[] { "Turno_Id" });
            DropIndex("dbo.OrdenDeProduccion", new[] { "HorarioActual_Id" });
            DropIndex("dbo.Defecto", new[] { "Horario_Id" });
            AlterColumn("dbo.Turno", "Fin", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Turno", "Inicio", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
            DropColumn("dbo.Par", "Horario_Id");
            DropColumn("dbo.OrdenDeProduccion", "HorarioActual_Id");
            DropColumn("dbo.Modelo", "Objetivo");
            DropColumn("dbo.Defecto", "Horario_Id");
            DropColumn("dbo.Color", "Codigo");
            DropTable("dbo.Horario");
            CreateIndex("dbo.Periodo", "OrdenDeProduccion_Id");
            CreateIndex("dbo.Periodo", "Turno_Id");
            CreateIndex("dbo.Par", "OrdenDeProduccion_Id");
            CreateIndex("dbo.Defecto", "OrdenDeProduccion_Id");
            AddForeignKey("dbo.Periodo", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion", "Id");
            AddForeignKey("dbo.Periodo", "Turno_Id", "dbo.Turno", "Id");
            AddForeignKey("dbo.Par", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion", "Id");
            AddForeignKey("dbo.Defecto", "OrdenDeProduccion_Id", "dbo.OrdenDeProduccion", "Id");
        }
    }
}
