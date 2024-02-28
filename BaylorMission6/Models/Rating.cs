using System.ComponentModel.DataAnnotations;

namespace BaylorMission6.Models
{
    public class Rating
    {
        [Key]
        
        public int ratingID { get; set; }
        
        public string category { get; set; }
        [Required(ErrorMessage = "Title is required")]

        public string title { get; set; }
        [Required(ErrorMessage = "Year is required")]
        [Range(1888, 2024, ErrorMessage = "Year must be between 1888 and 2024")]
        public int year { get; set; }
        
       
        public string director { get; set; }
        [Required(ErrorMessage = "Rating is required")]
        [RegularExpression(@"^(G|PG|PG-13|R)$", ErrorMessage = "Rating must be G, PG, PG-13, or R")]
        public string rating { get; set; }
        [Required(ErrorMessage = "Edited status is required")]
        public bool? edited { get; set; }

        public string? lentTo { get; set; }
        [MaxLength(25, ErrorMessage = "Notes cannot be more than 25 characters")]
        public string? notes { get; set; }

    }
}
