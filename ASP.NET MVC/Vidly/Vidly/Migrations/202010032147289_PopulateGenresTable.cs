namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES(1, 'Comedy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(2, 'Romance')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(3, 'Thriller')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(4, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(5, 'Sci-Fi')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(6, 'Crime')");
            Sql("INSERT INTO Genres (Id, Name) VALUES(7, 'Horror')");
        }
        
        public override void Down()
        {
        }
    }
}
