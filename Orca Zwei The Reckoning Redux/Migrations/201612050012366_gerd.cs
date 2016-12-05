namespace Orca_Zwei_The_Reckoning_Redux.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class gerd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Experts", "HomeInst", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Experts", "HomeInst");
        }
    }
}
