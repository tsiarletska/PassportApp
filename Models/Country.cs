using System.ComponentModel.DataAnnotations;

namespace PassportsApp.Models
{
    public class Country
    {
        [Key]  // SexAbr is PK
        public string? CountryCode { get; set; }
        [Required, MaxLength(10)]
        public string? CountryName { get; set; }
    }
}
