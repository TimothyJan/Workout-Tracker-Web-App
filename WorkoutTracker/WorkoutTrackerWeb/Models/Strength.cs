using System.ComponentModel.DataAnnotations;

namespace WorkoutTrackerWeb.Models
{
    //[Table("tblStrength")]
    public class Strength
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? Sets { get; set; }
        public int? RepsPerSet { get; set; }
        public int? Weights { get; set; }
        public string? StrengthNote { get; set; }
    }
}
