namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class renombradodemodeloServidorPublicoIFAIaServidorPublico : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId", "dbo.ServidorPublicoIFAI");
            DropIndex("dbo.Viajes", new[] { "ServidorPublicoIFAI_ServidorPublicoIFAIId" });
            CreateTable(
                "dbo.ServidoresPublicos",
                c => new
                    {
                        ServidorPublicoId = c.Int(nullable: false, identity: true),
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
                .PrimaryKey(t => t.ServidorPublicoId);
            
            AddColumn("dbo.Viajes", "ServidorPublico_ServidorPublicoId", c => c.Int());
            CreateIndex("dbo.Viajes", "ServidorPublico_ServidorPublicoId");
            AddForeignKey("dbo.Viajes", "ServidorPublico_ServidorPublicoId", "dbo.ServidoresPublicos", "ServidorPublicoId");
            DropColumn("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId");
            DropTable("dbo.ServidorPublicoIFAI");
        }
        
        public override void Down()
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
            DropForeignKey("dbo.Viajes", "ServidorPublico_ServidorPublicoId", "dbo.ServidoresPublicos");
            DropIndex("dbo.Viajes", new[] { "ServidorPublico_ServidorPublicoId" });
            DropColumn("dbo.Viajes", "ServidorPublico_ServidorPublicoId");
            DropTable("dbo.ServidoresPublicos");
            CreateIndex("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId");
            AddForeignKey("dbo.Viajes", "ServidorPublicoIFAI_ServidorPublicoIFAIId", "dbo.ServidorPublicoIFAI", "ServidorPublicoIFAIId");
        }
    }
}
