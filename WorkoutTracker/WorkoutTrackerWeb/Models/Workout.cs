using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTrackerWeb.Models
{
    //[Table("tblWorkout")]
    public class Workout
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public int? StrengthId { get; set; }
        public int? CardioId { get; set; }
    }
}
