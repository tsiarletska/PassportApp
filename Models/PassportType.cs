using System.ComponentModel.DataAnnotations;

namespace PassportsApp.Models
{
    public class PassportType
    {
        [Key] // PassportType is PK
        public string? PassportTypeAbr { get; set; } // P



        [MaxLength(255)]
        public string? PassportTypeDesc  { get; set; }


    }
}
