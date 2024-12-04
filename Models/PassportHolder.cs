using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PassportsApp.Models
{
    public class PassportHolder
    {   // HERE ARE 2 FKs: PassportId, Citienship
        [Key]
        public int HolderId { get; set; }
        [Required, MaxLength(10)]

        //FK - to passportId in "Passport"  
      //  [ForeignKey("Passport")] 
       // public int? PassportId { get; set; } // refer only to the PK
       // public Passport? Passport { get; set; }
        ///[Required, MaxLength(15)]
        //FK is over

        //FK new

        public int? PassportId { get; set; }
        [ForeignKey("PassportId")]
        public Passport? Passport { get; set; }


        public string? HolderName { get; set; }
        [Required, MaxLength(20)]
        public string? HolderSurname { get; set; }
        [Required, MaxLength(30)]
        public string? PatronymicMatronymic {  get; set; }

        public DateTime Birthday { get; set; }

        // FK to SexAtr in Sex
        //  [ForeignKey("Sex")]
        //   public string? SexAbr { get; set; }
        // [Required]
        // public Sex? Sex { get; set; }
        // FK to Sex Abr is over

        public string? SexAbr { get; set; }
        [ForeignKey("SexAbr")]
        public Sex? Sex { get; set; }



        public string? BirthPlace { get; set; }
        [Required, MaxLength(40)]

        // FR to countries
        //[ForeignKey("Country")]
        //public string? Citizenship { get; set; }
        // [Required]
        // public Country? Countries { get; set; }
        // FR to countries is over


        public string? Citizenship { get; set; }
        [ForeignKey("Citizenship")]
        public Country? Country { get; set; }


        //[ForeignKey("CountryCode")] public string? Citizenship { get; set; }
        //[Required] public Country? Country { get; set; }

        public string? Signature { get; set; } // binary data or path (string)
        public string? HolderPhoto { get; set; }

    }
}
