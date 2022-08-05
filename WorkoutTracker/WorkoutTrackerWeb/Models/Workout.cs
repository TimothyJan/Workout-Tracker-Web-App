using System.ComponentModel.DataAnnotations;

namespace WorkoutTrackerWeb.Models
{
    //[Table("tblWorkout")]
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string? Note { get; set; }
        public int? StrengthId { get; set; }
        public int? CardioId { get; set; }
    }
}
