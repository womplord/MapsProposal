namespace MapsProposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class rectangle : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Location");
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
                        Latitude = c.Double(nullable: false),
                        Longitude = c.Double(nullable: false),
                        NorthEastLatitude = c.Double(nullable: false),
                        NorthEastLongitude = c.Double(nullable: false),
                        SouthWestLatitude = c.Double(nullable: false),
                        SouthWestLongitude = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Location");
        }
    }
}
