using System.ComponentModel.DataAnnotations;

namespace Commander.DTOs {
    public class CommandReadDto {

        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }
    }
}