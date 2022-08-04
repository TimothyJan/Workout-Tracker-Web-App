using System.ComponentModel;
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
        [DisplayName("Cardio Name")]
        public string CardioName { get; set; }
        public string? Distance { get; set; }
        public string? Speed { get; set; }
        public string? Time { get; set; }
        public string? CardioNote { get; set; }
    }
}
