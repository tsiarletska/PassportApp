using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PassportsApp.Models
{
    public class Passport
    {
        [Key]
        public int PassportId { get; set; } // PK
        [Required, MaxLength(15)]

       // [ForeignKey("PassportType")]
        //public string? PasportType { get; set; }
        //public PassportType? PassportTypes { get; set; }



        
        public string? Type { get; set; }
        [ForeignKey("Type")]
        public PassportType? PassportType { get; set; }



        public DateTime IssueDate { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }

        [Required]
        public int AuthorityId { get; set; }
    }
}