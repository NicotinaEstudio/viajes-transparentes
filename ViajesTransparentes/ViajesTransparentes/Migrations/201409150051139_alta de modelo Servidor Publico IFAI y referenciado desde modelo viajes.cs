namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class altademodeloServidorPublicoIFAIyreferenciadodesdemodeloviajes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServidorPublicoIFAI",
                c => new
                    {
                        ServidorPublicoIFAIId = c.Int(nullable: false, identity: true),
                        Institucion = c.String(nullable: false),
                        Nombre = c.String(nullable: false),
                        PrimerApellido = c.String(nullable: false),
                        SegundoApellido = c.String(nullable: false),
                        NombreCompleto = c.String(nullable: false),
                        TipoDePersonal = c.String(nullable: false),
                        NombreDelCargo = c.String(nullable: false),
                        NombreDelCargoSuperior = c.String(nullable: false),
                        UnidadAdministrativa = c.String(nullable: false),
                        ClaveDelPuesto = c.String(nullable: false),
                        NombreDelPuesto = c.String(nullable: false),
                        CorreoElectrónico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ServidorPublicoIFAIId);
            
            AddColumn("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId", c => c.Int());
            CreateIndex("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId");
            AddForeignKey("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId", "dbo.ServidorPublicoIFAI", "ServidorPublicoIFAIId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId", "dbo.ServidorPublicoIFAI");
            DropIndex("dbo.Viajes", new[] { "ServidorPublicoIFAI_ServidorPublicoIFAIId" });
            DropColumn("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId");
            DropTable("dbo.ServidorPublicoIFAI");
        }
    }
}
