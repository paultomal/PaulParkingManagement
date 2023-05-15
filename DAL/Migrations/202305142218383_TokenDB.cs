namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TokenDB : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Tokens", "CustomerId", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Tokens", "CustomerId");
        }
    }
}
