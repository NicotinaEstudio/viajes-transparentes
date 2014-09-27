namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Comisiones",
                c => new
                    {
                        ComisionId = c.Int(nullable: false, identity: true),
                        PersonaId = c.Int(nullable: false),
                        MEC_ORIGEN = c.Int(nullable: false),
                        INST_GENERA = c.String(nullable: false),
                        UR = c.String(nullable: false),
                        TIPO_REP = c.Int(nullable: false),
                        CONSECUTIVO = c.String(nullable: false),
                        CARGO = c.String(nullable: false),
                        GRUPO = c.String(nullable: false),
                        ACUERDO = c.String(nullable: false),
                        OFICIO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComisionId)
                .ForeignKey("dbo.ServidoresPublicos", t => t.PersonaId)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        PrimerApellido = c.String(nullable: false),
                        SegundoApellido = c.String(nullable: false),
                        NombreCompleto = c.String(nullable: false),
                        CorreoElectrónico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaId);
            
            CreateTable(
                "dbo.Viajes",
                c => new
                    {
                        ViajeId = c.Int(nullable: false, identity: true),
                        ComisionId = c.Int(nullable: false),
                        TIPO_VIAJE = c.Int(nullable: false),
                        PAIS_ORIGEN = c.String(nullable: false),
                        ESTADO_ORIGEN = c.String(nullable: false),
                        CIUDAD_ORIGEN = c.String(nullable: false),
                        PAIS_DESTINO = c.String(nullable: false),
                        ESTADO_DESTINO = c.String(nullable: false),
                        CIUDAD_DESTINO = c.String(nullable: false),
                        TARIFA_DIARIA = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MONEDA = c.Int(nullable: false),
                        TEMA = c.Int(nullable: false),
                        TIPO_COM = c.Int(nullable: false),
                        EVENTO = c.String(),
                        URL_EVENTO = c.String(),
                        FECHAINICIO_PART = c.DateTime(nullable: false),
                        FECHAFIN_PART = c.DateTime(nullable: false),
                        MOTIVO = c.String(),
                        ANTECEDENTE = c.String(),
                        ACTIVIDAD = c.String(),
                        RESULTADO = c.String(),
                        CONTRIBUCION_IFAI = c.String(),
                        URL_COMUNICADO = c.String(),
                        CUBRE_PASAJE = c.String(),
                        TIPO_PASAJE = c.Int(nullable: false),
                        LINEA_ORIGEN = c.String(),
                        VUELO_ORIGEN = c.String(),
                        LINEA_REGRESO = c.String(),
                        VUELO_REGRESO = c.String(),
                        FECHAINICIO_COM = c.DateTime(nullable: false),
                        FECHAFIN_COM = c.DateTime(nullable: false),
                        GASTO_PASAJE = c.Decimal(nullable: false, precision: 18, scale: 2),
                        GASTO_VIATICO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        INST_HOSPEDAJE = c.String(),
                        HOTEL = c.String(),
                        FECHAINICIO_HOTEL = c.DateTime(nullable: false),
                        FECHAFIN_HOTEL = c.DateTime(nullable: false),
                        COSTO_HOTEL = c.Decimal(nullable: false, precision: 18, scale: 2),
                        COMPROBADO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SIN_COMPROBAR = c.Decimal(nullable: false, precision: 18, scale: 2),
                        VIATICO_DEVUELTO = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OBSERVACIONES = c.String(),
                    })
                .PrimaryKey(t => t.ViajeId)
                .ForeignKey("dbo.Comisiones", t => t.ComisionId, cascadeDelete: true)
                .Index(t => t.ComisionId);
            
            CreateTable(
                "dbo.ServidoresPublicos",
                c => new
                    {
                        PersonaId = c.Int(nullable: false),
                        Institucion = c.String(nullable: false),
                        TipoDePersonal = c.String(nullable: false),
                        NombreDelCargo = c.String(nullable: false),
                        NombreDelCargoSuperior = c.String(nullable: false),
                        UnidadAdministrativa = c.String(nullable: false),
                        ClaveDelPuesto = c.String(nullable: false),
                        NombreDelPuesto = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaId)
                .ForeignKey("dbo.Personas", t => t.PersonaId)
                .Index(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServidoresPublicos", "PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Viajes", "ComisionId", "dbo.Comisiones");
            DropForeignKey("dbo.Comisiones", "PersonaId", "dbo.ServidoresPublicos");
            DropIndex("dbo.ServidoresPublicos", new[] { "PersonaId" });
            DropIndex("dbo.Viajes", new[] { "ComisionId" });
            DropIndex("dbo.Comisiones", new[] { "PersonaId" });
            DropTable("dbo.ServidoresPublicos");
            DropTable("dbo.Viajes");
            DropTable("dbo.Personas");
            DropTable("dbo.Comisiones");
        }
    }
}
