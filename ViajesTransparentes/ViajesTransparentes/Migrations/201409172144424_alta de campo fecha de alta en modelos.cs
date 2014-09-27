namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altadecampofechadealtaenmodelos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comisiones", "FechaDeAlta", c => c.DateTime(nullable: false));
            AddColumn("dbo.Comisiones", "FechaDeMod", c => c.DateTime(nullable: false));
            AddColumn("dbo.Personas", "EsActivo", c => c.Boolean(nullable: false));
            AddColumn("dbo.Personas", "EsVerificado", c => c.Boolean(nullable: false));
            AddColumn("dbo.Personas", "EsCompleto", c => c.Boolean(nullable: false));
            AddColumn("dbo.Personas", "FechaDeAlta", c => c.DateTime(nullable: false));
            AddColumn("dbo.Personas", "FechaDeMod", c => c.DateTime(nullable: false));
            AddColumn("dbo.Viajes", "FechaDeAlta", c => c.DateTime(nullable: false));
            AddColumn("dbo.Viajes", "FechaDeMod", c => c.DateTime(nullable: false));
            AlterColumn("dbo.ServidoresPublicos", "Institucion", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.ServidoresPublicos", "TipoDePersonal", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargo", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargoSuperior", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "UnidadAdministrativa", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "ClaveDelPuesto", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelPuesto", c => c.String(nullable: false, maxLength: 200));
            AlterColumn("dbo.Personas", "Nombre", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Personas", "PrimerApellido", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Personas", "SegundoApellido", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "SegundoApellido", c => c.String(maxLength: 100));
            AlterColumn("dbo.Personas", "PrimerApellido", c => c.String(maxLength: 100));
            AlterColumn("dbo.Personas", "Nombre", c => c.String(maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelPuesto", c => c.String(maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "ClaveDelPuesto", c => c.String(maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "UnidadAdministrativa", c => c.String(maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargoSuperior", c => c.String(maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargo", c => c.String(maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "TipoDePersonal", c => c.String(maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "Institucion", c => c.String(maxLength: 500));
            DropColumn("dbo.Viajes", "FechaDeMod");
            DropColumn("dbo.Viajes", "FechaDeAlta");
            DropColumn("dbo.Personas", "FechaDeMod");
            DropColumn("dbo.Personas", "FechaDeAlta");
            DropColumn("dbo.Personas", "EsCompleto");
            DropColumn("dbo.Personas", "EsVerificado");
            DropColumn("dbo.Personas", "EsActivo");
            DropColumn("dbo.Comisiones", "FechaDeMod");
            DropColumn("dbo.Comisiones", "FechaDeAlta");
        }
    }
}
