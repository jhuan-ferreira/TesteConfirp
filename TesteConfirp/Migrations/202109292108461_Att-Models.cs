namespace TesteConfirp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttModels : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Estudantes", "Cursos_Id", "dbo.Cursos");
            DropIndex("dbo.Estudantes", new[] { "Cursos_Id" });
            DropColumn("dbo.Estudantes", "CursoId");
            RenameColumn(table: "dbo.Estudantes", name: "Cursos_Id", newName: "CursoId");
            AlterColumn("dbo.Estudantes", "CursoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Estudantes", "CursoId");
            AddForeignKey("dbo.Estudantes", "CursoId", "dbo.Cursos", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Estudantes", "CursoId", "dbo.Cursos");
            DropIndex("dbo.Estudantes", new[] { "CursoId" });
            AlterColumn("dbo.Estudantes", "CursoId", c => c.Int());
            RenameColumn(table: "dbo.Estudantes", name: "CursoId", newName: "Cursos_Id");
            AddColumn("dbo.Estudantes", "CursoId", c => c.Int(nullable: false));
            CreateIndex("dbo.Estudantes", "Cursos_Id");
            AddForeignKey("dbo.Estudantes", "Cursos_Id", "dbo.Cursos", "Id");
        }
    }
}
