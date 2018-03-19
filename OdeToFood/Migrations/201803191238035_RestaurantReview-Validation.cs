namespace OdeToFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestaurantReviewValidation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RestaurantReviews", "Body", c => c.String(nullable: false, maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RestaurantReviews", "Body", c => c.String());
        }
    }
}
