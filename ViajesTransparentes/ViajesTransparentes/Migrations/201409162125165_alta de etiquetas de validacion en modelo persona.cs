namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altadeetiquetasdevalidacionenmodelopersona : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personas", "Nombre", c => c.String(maxLength: 100));
            AlterColumn("dbo.Personas", "PrimerApellido", c => c.String(maxLength: 100));
            AlterColumn("dbo.Personas", "SegundoApellido", c => c.String(maxLength: 100));
            AlterColumn("dbo.Personas", "NombreCompleto", c => c.String(maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personas", "NombreCompleto", c => c.String(nullable: false));
            AlterColumn("dbo.Personas", "SegundoApellido", c => c.String(nullable: false));
            AlterColumn("dbo.Personas", "PrimerApellido", c => c.String(nullable: false));
            AlterColumn("dbo.Personas", "Nombre", c => c.String(nullable: false));
        }
    }
}
