namespace Orca_Zwei_The_Reckoning_Redux.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class message : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageID = c.Int(nullable: false, identity: true),
                        SentFrom = c.String(nullable: false),
                        SentTo = c.String(nullable: false),
                        Subject = c.String(),
                        MessageSent = c.String(),
                        Read = c.Boolean(nullable: false),
                        Sent = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MessageID);
            
            AlterColumn("dbo.Experts", "HomeInst", c => c.String(nullable: false));
            AlterColumn("dbo.Experts", "WorkPhone", c => c.String(nullable: false));
            AlterColumn("dbo.Experts", "Specialties", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Experts", "Specialties", c => c.String());
            AlterColumn("dbo.Experts", "WorkPhone", c => c.String());
            AlterColumn("dbo.Experts", "HomeInst", c => c.String());
            DropTable("dbo.Messages");
        }
    }
}
