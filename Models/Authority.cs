using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportsApp.Models
{
    public class Authority
    {
        [Key]
        public int AutorityId { get; set; }
        [Required]


        //public string? Country {  get; set; }
        //[ForeignKey("Country")]
       // public Country Country { get; set; }

        public string? CountryCode { get; set; }
        [ForeignKey("CountryCode")]
        public Country? Country { get; set; }


        //public string? Country { get; set; }  // This is the foreign key column in Authority

        // Navigation property to the Country entity
        // [ForeignKey("Country")]
        // public Country? Countries { get; set; }  // Renamed to avoid conflict

        public string? City { get; set; }
        public string? Street { get; set; }
        public string? HouseNum { get; set; }
        public string? Phone { get; set; }

        [Required, MaxLength(255)]
        public string? Email { get; set; }

        [Required]
        public DateTime EstablishmentDate { get; set; }
    }
}


