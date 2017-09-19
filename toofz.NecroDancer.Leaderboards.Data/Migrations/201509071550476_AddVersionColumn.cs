namespace toofz.NecroDancer.Leaderboards.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVersionColumn : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Replays", "Version", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Replays", "Version");
        }
    }
}