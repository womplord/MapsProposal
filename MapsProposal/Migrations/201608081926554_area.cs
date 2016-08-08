namespace MapsProposal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class area : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Location", "RectangleArea", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Location", "RectangleArea");
        }
    }
}
