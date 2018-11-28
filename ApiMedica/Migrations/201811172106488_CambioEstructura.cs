namespace ApiMedica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructura : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TipoCitas", "Nombre", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.TipoCitas", "Descripcion", c => c.String(maxLength: 200));
            AlterColumn("dbo.TipoCitas", "Imagen", c => c.String(nullable: false, maxLength: 80));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoCitas", "Imagen", c => c.String());
            AlterColumn("dbo.TipoCitas", "Descripcion", c => c.String());
            AlterColumn("dbo.TipoCitas", "Nombre", c => c.String());
        }
    }
}
