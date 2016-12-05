namespace Orca_Zwei_The_Reckoning_Redux.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experts", "Email", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "Expert", c => c.Boolean(nullable: false));
            DropColumn("dbo.Experts", "Username");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Experts", "Username", c => c.String());
            DropColumn("dbo.AspNetUsers", "Expert");
            DropColumn("dbo.AspNetUsers", "LastName");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.Experts", "Email");
        }
    }
}
