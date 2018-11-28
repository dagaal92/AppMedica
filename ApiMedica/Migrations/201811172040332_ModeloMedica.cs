namespace ApiMedica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModeloMedica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoCitas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Descripcion = c.String(),
                        Cantidad = c.Int(nullable: false),
                        Imagen = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoCitas");
        }
    }
}
