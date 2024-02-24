using System.ComponentModel.DataAnnotations;

namespace BaylorMission6.Models
{
    public class Rating
    {
        [Key]
        [Required]
        public int ratingID { get; set; }
        [Required]
        public string category { get; set; }
        [Required]

        public string title { get; set; }
        [Required]

        public int year { get; set; }
        [Required]

        public string director { get; set; }
        [Required]

        public string rating { get; set; }

        public bool edited { get; set; }

        public string lentTo { get; set; }

        public string notes { get; set; }

    }
}
