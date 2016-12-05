namespace Orca_Zwei_The_Reckoning_Redux.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class merg : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experts", "FirstName", c => c.String(nullable: false));
            AddColumn("dbo.Experts", "LastName", c => c.String(nullable: false));
            DropColumn("dbo.Experts", "HomeInst");
            DropColumn("dbo.AspNetUsers", "FirstName");
            DropColumn("dbo.AspNetUsers", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "LastName", c => c.String());
            AddColumn("dbo.AspNetUsers", "FirstName", c => c.String());
            AddColumn("dbo.Experts", "HomeInst", c => c.String(nullable: false));
            DropColumn("dbo.Experts", "LastName");
            DropColumn("dbo.Experts", "FirstName");
        }
    }
}
