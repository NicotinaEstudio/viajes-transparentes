namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class etiquetasdevalidacionentodoslosmodelos : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comisiones", "INST_GENERA", c => c.String(maxLength: 300));
            AlterColumn("dbo.Comisiones", "UR", c => c.String(maxLength: 300));
            AlterColumn("dbo.Comisiones", "CARGO", c => c.String(maxLength: 100));
            AlterColumn("dbo.Comisiones", "GRUPO", c => c.String(maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "Institucion", c => c.String(maxLength: 500));
            AlterColumn("dbo.ServidoresPublicos", "TipoDePersonal", c => c.String(maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargo", c => c.String(maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargoSuperior", c => c.String(maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "UnidadAdministrativa", c => c.String(maxLength: 200));
            AlterColumn("dbo.ServidoresPublicos", "ClaveDelPuesto", c => c.String(maxLength: 100));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelPuesto", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ServidoresPublicos", "NombreDelPuesto", c => c.String(nullable: false));
            AlterColumn("dbo.ServidoresPublicos", "ClaveDelPuesto", c => c.String(nullable: false));
            AlterColumn("dbo.ServidoresPublicos", "UnidadAdministrativa", c => c.String(nullable: false));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargoSuperior", c => c.String(nullable: false));
            AlterColumn("dbo.ServidoresPublicos", "NombreDelCargo", c => c.String(nullable: false));
            AlterColumn("dbo.ServidoresPublicos", "TipoDePersonal", c => c.String(nullable: false));
            AlterColumn("dbo.ServidoresPublicos", "Institucion", c => c.String(nullable: false));
            AlterColumn("dbo.Comisiones", "GRUPO", c => c.String(nullable: false));
            AlterColumn("dbo.Comisiones", "CARGO", c => c.String(nullable: false));
            AlterColumn("dbo.Comisiones", "UR", c => c.String(nullable: false));
            AlterColumn("dbo.Comisiones", "INST_GENERA", c => c.String(nullable: false));
        }
    }
}
