using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkoutTrackerWeb.Models
{
    //[Table("tblCardio")]
    public class Cardio
    {
        [Key]
        public int CardioId { get; set; }
        [Required]
        public string CardioName { get; set; }
        public int? Distance { get; set; }
        public int? Speed { get; set; }
        public int? Time { get; set; }
        public string? Note { get; set; }
    }
}
