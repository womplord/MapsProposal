namespace MapsProposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class optional : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Location", "Latitude", c => c.Double());
            AlterColumn("dbo.Location", "Longitude", c => c.Double());
            AlterColumn("dbo.Location", "NorthEastLatitude", c => c.Double());
            AlterColumn("dbo.Location", "NorthEastLongitude", c => c.Double());
            AlterColumn("dbo.Location", "SouthWestLatitude", c => c.Double());
            AlterColumn("dbo.Location", "SouthWestLongitude", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Location", "SouthWestLongitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Location", "SouthWestLatitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Location", "NorthEastLongitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Location", "NorthEastLatitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Location", "Longitude", c => c.Double(nullable: false));
            AlterColumn("dbo.Location", "Latitude", c => c.Double(nullable: false));
        }
    }
}
