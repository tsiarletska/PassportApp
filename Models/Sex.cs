using System.ComponentModel.DataAnnotations;

namespace PassportsApp.Models
{
    public class Sex
    {
        [Key]  // SexAbr is PK
        public string? SexAbr { get; set; }
        [Required, MaxLength(10)]
        public string? FullSex  { get; set; }
    }
}
