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
                        FechaDeAlta = c.DateTime(nullable: false),
                        FechaDeMod = c.DateTime(nullable: false),
                        MEC_ORIGEN = c.Int(nullable: false),
                        INST_GENERA = c.String(maxLength: 300),
                        UR = c.String(maxLength: 300),
                        TIPO_REP = c.Int(nullable: false),
                        CONSECUTIVO = c.String(nullable: false),
                        CARGO = c.String(maxLength: 100),
                        GRUPO = c.String(maxLength: 100),
                        ACUERDO = c.String(nullable: false),
                        OFICIO = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ComisionId)
                .ForeignKey("dbo.ServidoresPublicos", t => t.PersonaId)
                .Index(t => t.PersonaId);
            
            CreateTable(
                "dbo.Personas",
                c => new
                    {
                        PersonaId = c.Int(nullable: false, identity: true),
                        EsActivo = c.Boolean(nullable: false),
                        EsVerificado = c.Boolean(nullable: false),
                        EsCompleto = c.Boolean(nullable: false),
                        FechaDeAlta = c.DateTime(nullable: false),
                        FechaDeMod = c.DateTime(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        PrimerApellido = c.String(nullable: false, maxLength: 100),
                        SegundoApellido = c.String(nullable: false, maxLength: 100),
                        NombreCompleto = c.String(maxLength: 500),
                        CorreoElectronico = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaId);
            
            CreateTable(
                "dbo.GruposJerarquicos",
                c => new
                    {
                        GrupoJerarquicoId = c.Int(nullable: false, identity: true),
                        Codigo = c.String(nullable: false, maxLength: 5),
                    })
                .PrimaryKey(t => t.GrupoJerarquicoId);
            
            CreateTable(
                "dbo.Viajes",
                c => new
                    {
                        ViajeId = c.Int(nullable: false, identity: true),
                        ComisionId = c.Int(nullable: false),
                        FechaDeAlta = c.DateTime(nullable: false),
                        FechaDeMod = c.DateTime(nullable: false),
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
                "dbo.Comprobantes",
                c => new
                    {
                        ComprobanteId = c.Int(nullable: false, identity: true),
                        ComisionId = c.Int(nullable: false),
                        FechaDeAlta = c.DateTime(nullable: false),
                        Concepto = c.String(),
                        Importe = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ClaveDeJustificacion = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ComprobanteId)
                .ForeignKey("dbo.Comisiones", t => t.ComisionId, cascadeDelete: true)
                .Index(t => t.ComisionId);
            
            CreateTable(
                "dbo.Viaticos",
                c => new
                    {
                        ViaticoId = c.Int(nullable: false, identity: true),
                        GrupoJerarquicoId = c.Int(nullable: false),
                        TipoViaje = c.Int(nullable: false),
                        ZonaDestino = c.Int(nullable: false),
                        TarifaDiariaViaticosMXP = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TarifaDiariaViaticosUSD = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ViaticoId)
                .ForeignKey("dbo.GruposJerarquicos", t => t.GrupoJerarquicoId, cascadeDelete: true)
                .Index(t => t.GrupoJerarquicoId);
            
            CreateTable(
                "dbo.ServidoresPublicos",
                c => new
                    {
                        PersonaId = c.Int(nullable: false),
                        GrupoJerarquicoId = c.Int(nullable: false),
                        Institucion = c.String(nullable: false, maxLength: 500),
                        TipoDePersonal = c.String(nullable: false, maxLength: 100),
                        NombreDelCargo = c.String(nullable: false, maxLength: 200),
                        NombreDelCargoSuperior = c.String(nullable: false, maxLength: 200),
                        UnidadAdministrativa = c.String(nullable: false, maxLength: 200),
                        NombreDelPuesto = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.PersonaId)
                .ForeignKey("dbo.Personas", t => t.PersonaId)
                .ForeignKey("dbo.GruposJerarquicos", t => t.GrupoJerarquicoId, cascadeDelete: true)
                .Index(t => t.PersonaId)
                .Index(t => t.GrupoJerarquicoId);
            
            CreateTable(
                "dbo.Usuarios",
                c => new
                    {
                        PersonaId = c.Int(nullable: false),
                        Contrasena = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.PersonaId)
                .ForeignKey("dbo.Personas", t => t.PersonaId)
                .Index(t => t.PersonaId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuarios", "PersonaId", "dbo.Personas");
            DropForeignKey("dbo.ServidoresPublicos", "GrupoJerarquicoId", "dbo.GruposJerarquicos");
            DropForeignKey("dbo.ServidoresPublicos", "PersonaId", "dbo.Personas");
            DropForeignKey("dbo.Viaticos", "GrupoJerarquicoId", "dbo.GruposJerarquicos");
            DropForeignKey("dbo.Comprobantes", "ComisionId", "dbo.Comisiones");
            DropForeignKey("dbo.Viajes", "ComisionId", "dbo.Comisiones");
            DropForeignKey("dbo.Comisiones", "PersonaId", "dbo.ServidoresPublicos");
            DropIndex("dbo.Usuarios", new[] { "PersonaId" });
            DropIndex("dbo.ServidoresPublicos", new[] { "GrupoJerarquicoId" });
            DropIndex("dbo.ServidoresPublicos", new[] { "PersonaId" });
            DropIndex("dbo.Viaticos", new[] { "GrupoJerarquicoId" });
            DropIndex("dbo.Comprobantes", new[] { "ComisionId" });
            DropIndex("dbo.Viajes", new[] { "ComisionId" });
            DropIndex("dbo.Comisiones", new[] { "PersonaId" });
            DropTable("dbo.Usuarios");
            DropTable("dbo.ServidoresPublicos");
            DropTable("dbo.Viaticos");
            DropTable("dbo.Comprobantes");
            DropTable("dbo.Viajes");
            DropTable("dbo.GruposJerarquicos");
            DropTable("dbo.Personas");
            DropTable("dbo.Comisiones");
        }
    }
}
