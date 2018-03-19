namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdRestaurantReviewsTblAddedReviewerName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RestaurantReviews", "ReviewerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RestaurantReviews", "ReviewerName");
        }
    }
}
