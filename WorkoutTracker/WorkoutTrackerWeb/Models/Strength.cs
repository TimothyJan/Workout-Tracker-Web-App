using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTrackerWeb.Models
{
    //[Table("tblStrength")]
    public class Strength
    {
        [Key]
        public int StrengthId { get; set; }
        [Required]
        public string StrengthName { get; set; }
        public int? Sets { get; set; }
        public int? RepsPerSet { get; set; }
        public int? Weights { get; set; }
        public string? Note { get; set; }
    }
}
