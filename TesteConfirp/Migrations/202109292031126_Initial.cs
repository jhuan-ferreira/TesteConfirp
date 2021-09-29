namespace TesteConfirp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cursos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Estudantes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Telefone = c.String(),
                        CursoId = c.Int(nullable: false),
                        Cursos_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cursos", t => t.Cursos_Id)
                .Index(t => t.Cursos_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estudantes", "Cursos_Id", "dbo.Cursos");
            DropIndex("dbo.Estudantes", new[] { "Cursos_Id" });
            DropTable("dbo.Estudantes");
            DropTable("dbo.Cursos");
        }
    }
}
