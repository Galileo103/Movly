namespace Movly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBitrhDayColumn1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Birthdate", c => c.DateTime());
            DropColumn("dbo.Customers", "BirthDay");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "BirthDay", c => c.DateTime());
            DropColumn("dbo.Customers", "Birthdate");
        }
    }
}
