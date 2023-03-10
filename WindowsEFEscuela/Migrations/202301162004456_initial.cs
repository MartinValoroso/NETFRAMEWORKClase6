namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alumnoes",
                c => new
                    {
                        AlumnoId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Apellido = c.String(),
                        FechaNacimiento = c.DateTime(),
                    })
                .PrimaryKey(t => t.AlumnoId);
            
            CreateTable(
                "dbo.Profesors",
                c => new
                    {
                        ProfesorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Apellido = c.String(),
                    })
                .PrimaryKey(t => t.ProfesorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Profesors");
            DropTable("dbo.Alumnoes");
        }
    }
}
