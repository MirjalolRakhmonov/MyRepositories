namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthdateToSomeOfCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1985-02-05' AS DATETIME) WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
