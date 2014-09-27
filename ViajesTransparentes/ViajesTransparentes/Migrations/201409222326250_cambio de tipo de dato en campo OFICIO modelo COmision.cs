namespace ViajesTransparentes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambiodetipodedatoencampoOFICIOmodeloCOmision : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Comisiones", "OFICIO", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Comisiones", "OFICIO", c => c.Int(nullable: false));
        }
    }
}
