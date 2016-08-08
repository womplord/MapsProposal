namespace MapsProposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class defaultvalues2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Location", "Height", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "Area", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "Water", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "SettlementSize", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "SocialInfrastructure", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "Influx", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "Forestry", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "LandUse", c => c.Boolean(defaultValue: false));
            AlterColumn("dbo.Location", "VegetationCover", c => c.Boolean(defaultValue: false));
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
