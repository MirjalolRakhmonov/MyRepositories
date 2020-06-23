namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategoryColumnToGenresTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Genres", "Category_Id", c => c.Int());
            CreateIndex("dbo.Genres", "Category_Id");
            AddForeignKey("dbo.Genres", "Category_Id", "dbo.Categories", "Id");
            Sql("UPDATE Genres SET Category_Id=1");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Genres", "Category_Id", "dbo.Categories");
            DropIndex("dbo.Genres", new[] { "Category_Id" });
            DropColumn("dbo.Genres", "Category_Id");
        }
    }
}
