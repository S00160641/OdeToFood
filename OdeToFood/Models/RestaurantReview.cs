using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    public class RestaurantReview
    {
        // Restaurant Id
        public int Id { get; set; }
        // Rating
        [Range(1,10)]
        [Required]
        public int Rating { get; set; }
        // Body
        [Required]
        [StringLength(1024)]
        public string Body { get; set; }
        // Reviewer Name
        [Display(Name = "User Name")]
        [DisplayFormat(NullDisplayText = "anonymous")]
        public string ReviewerName { get; set; }
        public int RestaurantId { get; set; } // A Review has a Restaurant
    }
}