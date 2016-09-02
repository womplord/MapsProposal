namespace MapsProposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Location",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        VegetationCover = c.Boolean(nullable: false),
                        LandUse = c.Boolean(nullable: false),
                        Forestry = c.Boolean(nullable: false),
                        Influx = c.Boolean(nullable: false),
                        SocialInfrastructure = c.Boolean(nullable: false),
                        SettlementSize = c.Boolean(nullable: false),
                        Water = c.Boolean(nullable: false),
                        Area = c.Boolean(nullable: false),
                        Height = c.Boolean(nullable: false),
                        LocationType = c.Int(nullable: false),
                        Latitude = c.Double(),
                        Longitude = c.Double(),
                        NorthEastLatitude = c.Double(),
                        NorthEastLongitude = c.Double(),
                        SouthWestLatitude = c.Double(),
                        SouthWestLongitude = c.Double(),
                        RectangleArea = c.Double(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Location");
        }
    }
}
