using System.ComponentModel.DataAnnotations;

namespace BaylorMission6.Models
{
    public class Rating
    {
        [Key]
        
        public int ratingID { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public string category { get; set; }
        [Required(ErrorMessage = "Title is required")]

        public string title { get; set; }
        [Required(ErrorMessage = "Year is required")]

        public int year { get; set; }
        [Required(ErrorMessage = "Director is required")]
        [Range(1900, 2024, ErrorMessage = "Year must be between 1900 and 2024")]
        public string director { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        [RegularExpression(@"^(G|PG|PG-13|R)$", ErrorMessage = "Rating must be G, PG, PG-13, or R")]
        public string rating { get; set; }

        public bool? edited { get; set; }

        public string? lentTo { get; set; }
        [MaxLength(25, ErrorMessage = "Notes cannot be more than 25 characters")]
        public string? notes { get; set; }

    }
}
