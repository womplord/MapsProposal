namespace MapsProposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class defaultvalues : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Location", "VegetationCover", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "LandUse", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "Forestry", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "Influx", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "SocialInfrastructure", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "SettlementSize", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "Water", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "Area", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Location", "Height", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Location", "Height", c => c.Boolean());
            AlterColumn("dbo.Location", "Area", c => c.Boolean());
            AlterColumn("dbo.Location", "Water", c => c.Boolean());
            AlterColumn("dbo.Location", "SettlementSize", c => c.Boolean());
            AlterColumn("dbo.Location", "SocialInfrastructure", c => c.Boolean());
            AlterColumn("dbo.Location", "Influx", c => c.Boolean());
            AlterColumn("dbo.Location", "Forestry", c => c.Boolean());
            AlterColumn("dbo.Location", "LandUse", c => c.Boolean());
            AlterColumn("dbo.Location", "VegetationCover", c => c.Boolean());
        }
    }
}
