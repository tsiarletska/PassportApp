using PassportsApp.Data;
using PassportsApp.Models;

namespace PassportsApp.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();


                // Seed Sex - first sex
                if (!context.Sex.Any())
                {
                    context.Sex.AddRange(new List<Sex>
                    {
                        new Sex { SexAbr = "M", FullSex = "Male" },
                        new Sex { SexAbr = "F", FullSex = "Female" },
                        new Sex { SexAbr = "X", FullSex = "NotSpecified" }
                    });
                }
                context.SaveChanges();

                //Seed Countries

                if (!context.Country.Any())
                {
                    context.Country.AddRange(new List<Country>
                    {
                        new Country { CountryCode = "AFG", CountryName = "Afghanistan" },
                        new Country { CountryCode = "ALB", CountryName = "Albania" },
                        new Country { CountryCode = "DZA", CountryName = "Algeria" },
                        new Country { CountryCode = "ASM", CountryName = "American Samoa"},
                        new Country { CountryCode = "AND", CountryName = "Andorra"},
                        new Country { CountryCode = "AGO", CountryName = "Angola"},
                        new Country { CountryCode = "AIA", CountryName = "Anguilla"},
                        new Country { CountryCode = "ATA", CountryName = "Antarctica"},
                        new Country { CountryCode = "ATG", CountryName = "Antigua and Barbuda"},
                        new Country { CountryCode = "ATG", CountryName = "Antigua and Barbuda"},
                        new Country { CountryCode = "ARG", CountryName = "Argentina"},
                        new Country { CountryCode = "ARM", CountryName = "Armenia"},
                        new Country { CountryCode = "ABW", CountryName = "Aruba"},
                        new Country { CountryCode = "AUS", CountryName = "Australia"},
                        new Country { CountryCode = "AUT", CountryName = "Austria"},
                        new Country { CountryCode = "AZE", CountryName = "Azerbaijan"},
                        new Country { CountryCode = "BHS", CountryName = "Bahamas"},
                        new Country { CountryCode = "BHR", CountryName = "Bahrain"},
                        new Country { CountryCode = "BGD", CountryName = "Bangladesh"},
                        new Country { CountryCode = "BRB", CountryName = "Barbados"},
                        new Country { CountryCode = "BLR", CountryName = "Byelarus" },
                        new Country { CountryCode = "BEL", CountryName = "Belgium"},
                        new Country { CountryCode = "BLZ", CountryName = "Belize" },
                        new Country { CountryCode = "BEN", CountryName = "Benin" },
                        new Country { CountryCode = "BMU", CountryName = "Bermuda" },
                        new Country { CountryCode = "BTN", CountryName = "Bhutan" },
                        new Country { CountryCode = "BOL", CountryName = "Bolivia" },
                        new Country { CountryCode = "BES", CountryName = "Bonaire" },
                        new Country { CountryCode = "BIH", CountryName = "Bosnia and Herzegovina" },
                        new Country { CountryCode = "BWA", CountryName = "Botswana" },
                        new Country { CountryCode = "BVT", CountryName = "Bouvet Island" },
                        new Country { CountryCode = "BRA", CountryName = "Brazil" },
                        new Country { CountryCode = "IOT", CountryName = "British Territory" },
                        new Country { CountryCode = "BRN", CountryName = "Brunei Darussalam" },
                        new Country { CountryCode = "BGR", CountryName = "Bulgaria" },
                        new Country { CountryCode = "BFA", CountryName = "Burkina Faso" },
                        new Country { CountryCode = "BDI", CountryName = "Burundi" },
                        new Country { CountryCode = "CPV", CountryName = "Cabo Verde" },
                        new Country { CountryCode = "KHM", CountryName = "Cambodia" },
                        new Country { CountryCode = "CMR", CountryName = "Cameroon" },
                        new Country { CountryCode = "CAN", CountryName = "Canada" },
                        new Country { CountryCode = "CYM", CountryName = "Cayman Islands" },
                        new Country { CountryCode = "CAF", CountryName = "CAR" },
                        new Country { CountryCode = "TCD", CountryName = "Chad" },
                        new Country { CountryCode = "CHL", CountryName = "Chile" },
                        new Country { CountryCode = "CHN", CountryName = "China" },
                        new Country { CountryCode = "CXR", CountryName = "Christmas Island" },
                        new Country { CountryCode = "CCK", CountryName = "Cocos Islands" },
                        new Country { CountryCode = "COL", CountryName = "Colombia" },
                        new Country { CountryCode = "COM", CountryName = "Comoros" },
                        new Country { CountryCode = "COD", CountryName = "Congo" },
                        new Country { CountryCode = "COG", CountryName = "Congo" },
                        new Country { CountryCode = "COK", CountryName = "Cook Islands" },
                        new Country { CountryCode = "CRI", CountryName = "Costa Rica" },
                        new Country { CountryCode = "HRV", CountryName = "Croatia" },
                        new Country { CountryCode = "CUB", CountryName = "Cuba" },
                        new Country { CountryCode = "CUW", CountryName = "Curaçao" },
                        new Country { CountryCode = "CYP", CountryName = "Cyprus" },
                        new Country { CountryCode = "CZE", CountryName = "Czechia" },
                        new Country { CountryCode = "CIV", CountryName = "Côte d'Ivoire" },
                        new Country { CountryCode = "DNK", CountryName = "Denmark" },
                        new Country { CountryCode = "DJI", CountryName = "Djibouti" },
                        new Country { CountryCode = "DMA", CountryName = "Dominica" },
                        new Country { CountryCode = "DOM", CountryName = "Dominican" },
                        new Country { CountryCode = "ECU", CountryName = "Ecuador" },
                        new Country { CountryCode = "EGY", CountryName = "Egypt" },
                        new Country { CountryCode = "SLV", CountryName = "El Salvador" },
                        new Country { CountryCode = "GNQ", CountryName = "Equatorial Guinea" },
                        new Country { CountryCode = "ERI", CountryName = "Eritrea" },
                        new Country { CountryCode = "EST", CountryName = "Estonia" },
                        new Country { CountryCode = "SWZ", CountryName = "Eswatini" },
                        new Country { CountryCode = "ETH", CountryName = "Ethiopia" },
                        new Country { CountryCode = "FLK", CountryName = "Falkland Islands" },
                        new Country { CountryCode = "FRO", CountryName = "Faroe Islands" },
                        new Country { CountryCode = "FJI", CountryName = "Fiji" },
                        new Country { CountryCode = "FIN", CountryName = "Finland" }, // authority
                        new Country { CountryCode = "FRA", CountryName = "France" },
                        new Country { CountryCode = "GUF", CountryName = "French Guiana" },
                        new Country { CountryCode = "PYF", CountryName = "French Polynesia" },
                        new Country { CountryCode = "ATF", CountryName = "French Territories" },
                        new Country { CountryCode = "GAB", CountryName = "Gabon" },
                        new Country { CountryCode = "GMB", CountryName = "Gambia" },
                        new Country { CountryCode = "GEO", CountryName = "Georgia" },
                        new Country { CountryCode = "DEU", CountryName = "Germany" },
                        new Country { CountryCode = "GHA", CountryName = "Ghana" },
                        new Country { CountryCode = "GIB", CountryName = "Gibraltar" },
                        new Country { CountryCode = "GRC", CountryName = "Greece" },
                        new Country { CountryCode = "GRL", CountryName = "Greenland" }, //authority
                        new Country { CountryCode = "GRD", CountryName = "Grenada" },
                        new Country { CountryCode = "GLP", CountryName = "Guadeloupe" },
                        new Country { CountryCode = "GUM", CountryName = "Guam" },
                        new Country { CountryCode = "GTM", CountryName = "Guatemala" },
                        new Country { CountryCode = "GGY", CountryName = "Guernsey" },
                        new Country { CountryCode = "GIN", CountryName = "Guinea" },
                        new Country { CountryCode = "GNB", CountryName = "Guinea-Bissau" },
                        new Country { CountryCode = "GUY", CountryName = "Guyana" },
                        new Country { CountryCode = "HTI", CountryName = "Haiti" },
                        new Country { CountryCode = "HMD", CountryName = "Heard Island" },
                        new Country { CountryCode = "VAT", CountryName = "Holy See" },
                        new Country { CountryCode = "HND", CountryName = "Honduras" },
                        new Country { CountryCode = "HKG", CountryName = "Hong Kong" },
                        new Country { CountryCode = "HUN", CountryName = "Hungary" },
                        new Country { CountryCode = "ISL", CountryName = "Iceland" },
                        new Country { CountryCode = "IND", CountryName = "India" },
                        new Country { CountryCode = "IDN", CountryName = "Indonesia" },
                        new Country { CountryCode = "IRN", CountryName = "Iran" },
                        new Country { CountryCode = "IRQ", CountryName = "Iraq" },
                        new Country { CountryCode = "IRL", CountryName = "Ireland" }, // authority
                        new Country { CountryCode = "IMN", CountryName = "Isle of Man" },
                        new Country { CountryCode = "ISR", CountryName = "Israel" },
                        new Country { CountryCode = "ITA", CountryName = "Italy" },
                        new Country { CountryCode = "JAM", CountryName = "Jamaica" },
                        new Country { CountryCode = "JPN", CountryName = "Japan" },
                        new Country { CountryCode = "JEY", CountryName = "Jersey" },
                        new Country { CountryCode = "JOR", CountryName = "Jordan" },
                        new Country { CountryCode = "KAZ", CountryName = "Kazakhstan" },
                        new Country { CountryCode = "KEN", CountryName = "Kenya" },
                        new Country { CountryCode = "KIR", CountryName = "Kiribati" },
                        new Country { CountryCode = "PRK", CountryName = "North Korea" },
                        new Country { CountryCode = "KOR", CountryName = "South Korea" },
                        new Country { CountryCode = "KWT", CountryName = "Kuwait" },
                        new Country { CountryCode = "KGZ", CountryName = "Kyrgyzstan" },
                        new Country { CountryCode = "LAO", CountryName = "Lao" },
                        new Country { CountryCode = "LVA", CountryName = "Latvia" },
                        new Country { CountryCode = "LBN", CountryName = "Lebanon" },
                        new Country { CountryCode = "LSO", CountryName = "Lesotho" },
                        new Country { CountryCode = "LBR", CountryName = "Liberia" },
                        new Country { CountryCode = "LBY", CountryName = "Libya" },
                        new Country { CountryCode = "LIE", CountryName = "Liechtenstein" },
                        new Country { CountryCode = "LTU", CountryName = "Lithuania" }, // authority
                        new Country { CountryCode = "LUX", CountryName = "Luxembourg" },
                        new Country { CountryCode = "MAC", CountryName = "Macao" },
                        new Country { CountryCode = "MDG", CountryName = "Madagascar" },
                        new Country { CountryCode = "MWI", CountryName = "Malawi" },
                        new Country { CountryCode = "MYS", CountryName = "Malaysia" },
                        new Country { CountryCode = "MDV", CountryName = "Maldives" },
                        new Country { CountryCode = "MLI", CountryName = "Mali" },
                        new Country { CountryCode = "MLT", CountryName = "Malta" },
                        new Country { CountryCode = "MHL", CountryName = "Marshall Islands" },
                        new Country { CountryCode = "MTQ", CountryName = "Martinique" },
                        new Country { CountryCode = "MRT", CountryName = "Mauritania" },
                        new Country { CountryCode = "MUS", CountryName = "Mauritius" },
                        new Country { CountryCode = "MYT", CountryName = "Mayotte" },
                        new Country { CountryCode = "MEX", CountryName = "Mexico" },
                        new Country { CountryCode = "FSM", CountryName = "Micronesia" },
                        new Country { CountryCode = "MDA", CountryName = "Moldova" }, //authority
                        new Country { CountryCode = "MCO", CountryName = "Monaco" },
                        new Country { CountryCode = "MNG", CountryName = "Mongolia" },
                        new Country { CountryCode = "MNE", CountryName = "Montenegro" },
                        new Country { CountryCode = "MSR", CountryName = "Montserrat" },
                        new Country { CountryCode = "MAR", CountryName = "Morocco" },
                        new Country { CountryCode = "MOZ", CountryName = "Mozambique" },
                        new Country { CountryCode = "MMR", CountryName = "Myanmar" },
                        new Country { CountryCode = "NAM", CountryName = "Namibia" },
                        new Country { CountryCode = "NRU", CountryName = "Nauru" },
                        new Country { CountryCode = "NPL", CountryName = "Nepal" },
                        new Country { CountryCode = "NLD", CountryName = "Netherlands" },
                        new Country { CountryCode = "NCL", CountryName = "New Caledonia" },
                        new Country { CountryCode = "NZL", CountryName = "New Zealand" },
                        new Country { CountryCode = "NIC", CountryName = "Nicaragua" },
                        new Country { CountryCode = "NER", CountryName = "Niger" },
                        new Country { CountryCode = "NGA", CountryName = "Nigeria" },
                        new Country { CountryCode = "NIU", CountryName = "Niue" },
                        new Country { CountryCode = "NFK", CountryName = "Norfolk Island" },
                        new Country { CountryCode = "MNP", CountryName = "Mariana Islands" },
                        new Country { CountryCode = "NOR", CountryName = "Norway" },
                        new Country { CountryCode = "OMN", CountryName = "Oman" },
                        new Country { CountryCode = "PAK", CountryName = "Pakistan" },
                        new Country { CountryCode = "PLW", CountryName = "Palau" },
                        new Country { CountryCode = "PSE", CountryName = "Palestine" },
                        new Country { CountryCode = "PAN", CountryName = "Panama" },
                        new Country { CountryCode = "PNG", CountryName = "Papua New Guinea" },
                        new Country { CountryCode = "PRY", CountryName = "Paraguay" },
                        new Country { CountryCode = "PER", CountryName = "Peru" },
                        new Country { CountryCode = "PHL", CountryName = "Philippines" },
                        new Country { CountryCode = "PCN", CountryName = "Pitcairn" },
                        new Country { CountryCode = "POL", CountryName = "Poland" }, // authority
                        new Country { CountryCode = "PRT", CountryName = "Portugal" },
                        new Country { CountryCode = "PRI", CountryName = "Puerto Rico" },
                        new Country { CountryCode = "QAT", CountryName = "Qatar" },
                        new Country { CountryCode = "MKD", CountryName = "Macedonia" },
                        new Country { CountryCode = "ROU", CountryName = "Romania" },
                        new Country { CountryCode = "RUS", CountryName = "Terroris State" },
                        new Country { CountryCode = "RWA", CountryName = "Rwanda" },
                        new Country { CountryCode = "REU", CountryName = "Réunion" },
                        new Country { CountryCode = "BLM", CountryName = "Saint Barthélemy" },
                        new Country { CountryCode = "SHN", CountryName = "Saint Helena" },
                        new Country { CountryCode = "KNA", CountryName = "Saint Kitts and Nevis" },
                        new Country { CountryCode = "LCA", CountryName = "Saint Lucia" },
                        new Country { CountryCode = "MAF", CountryName = "Saint Martin" },
                        new Country { CountryCode = "SPM", CountryName = "Saint Pierre" },
                        new Country { CountryCode = "VCT", CountryName = "Saint Vincent" },
                        new Country { CountryCode = "WSM", CountryName = "Samoa" },
                        new Country { CountryCode = "SMR", CountryName = "San Marino" },
                        new Country { CountryCode = "STP", CountryName = "Sao Tome and Principe" },
                        new Country { CountryCode = "SAU", CountryName = "Saudi Arabia" },
                        new Country { CountryCode = "SEN", CountryName = "Senegal" },
                        new Country { CountryCode = "SRB", CountryName = "Serbia" },
                        new Country { CountryCode = "SYC", CountryName = "Seychelles" },
                        new Country { CountryCode = "SLE", CountryName = "Sierra Leone" },
                        new Country { CountryCode = "SGP", CountryName = "Singapore" },
                        new Country { CountryCode = "SXM", CountryName = "Sint Maarten" },
                        new Country { CountryCode = "SVK", CountryName = "Slovakia" },
                        new Country { CountryCode = "SVN", CountryName = "Slovenia" },
                        new Country { CountryCode = "SLB", CountryName = "Solomon Islands" },
                        new Country { CountryCode = "SOM", CountryName = "Somalia" },
                        new Country { CountryCode = "ZAF", CountryName = "South Africa" },
                        new Country { CountryCode = "SGS", CountryName = "South Georgia" },
                        new Country { CountryCode = "SSD", CountryName = "South Sudan" },
                        new Country { CountryCode = "ESP", CountryName = "Spain" },
                        new Country { CountryCode = "LKA", CountryName = "Sri Lanka" },
                        new Country { CountryCode = "SDN", CountryName = "Sudan" },
                        new Country { CountryCode = "SUR", CountryName = "Suriname" },
                        new Country { CountryCode = "SJM", CountryName = "Svalbard" },
                        new Country { CountryCode = "SWE", CountryName = "Sweden" },
                        new Country { CountryCode = "CHE", CountryName = "Switzerland" },
                        new Country { CountryCode = "SYR", CountryName = "Syria" },
                        new Country { CountryCode = "TWN", CountryName = "Taiwan" },
                        new Country { CountryCode = "TJK", CountryName = "Tajikistan" },
                        new Country { CountryCode = "TZA", CountryName = "Tanzania" },
                        new Country { CountryCode = "THA", CountryName = "Thailand" },
                        new Country { CountryCode = "TLS", CountryName = "Timor-Leste" },
                        new Country { CountryCode = "TGO", CountryName = "Togo" },
                        new Country { CountryCode = "TKL", CountryName = "Tokelau" },
                        new Country { CountryCode = "TON", CountryName = "Tonga" },
                        new Country { CountryCode = "TTO", CountryName = "Trinidad and Tobago" },
                        new Country { CountryCode = "TUN", CountryName = "Tunisia" },
                        new Country { CountryCode = "TUR", CountryName = "Turkey" },
                        new Country { CountryCode = "TKM", CountryName = "Turkmenistan" },
                        new Country { CountryCode = "TCA", CountryName = "Turks-Caicos Islands" },
                        new Country { CountryCode = "TUV", CountryName = "Tuvalu" },
                        new Country { CountryCode = "UGA", CountryName = "Uganda" },
                        new Country { CountryCode = "UKR", CountryName = "Ukraine" }, // authority
                        new Country { CountryCode = "ARE", CountryName = "UAE" },
                        new Country { CountryCode = "GBR", CountryName = "UK" },
                        new Country { CountryCode = "UMI", CountryName = "UІ Minor Islands" },
                        new Country { CountryCode = "USA", CountryName = "USA" },
                        new Country { CountryCode = "URY", CountryName = "Uruguay" },
                        new Country { CountryCode = "UZB", CountryName = "Uzbekistan" },
                        new Country { CountryCode = "VUT", CountryName = "Vanuatu" },
                        new Country { CountryCode = "VEN", CountryName = "Venezuela" },
                        new Country { CountryCode = "VNM", CountryName = "Viet Nam" },
                        new Country { CountryCode = "VGB", CountryName = "Virgin Islands" },
                        new Country { CountryCode = "VIR", CountryName = "Virgin Islands" },
                        new Country { CountryCode = "WLF", CountryName = "Wallis and Futuna" },
                        new Country { CountryCode = "ESH", CountryName = "Western Sahara" },
                        new Country { CountryCode = "YEM", CountryName = "Yemen" },
                        new Country { CountryCode = "ZMB", CountryName = "Zambia" },
                        new Country { CountryCode = "ZWE", CountryName = "Zimbabwe" },
                        new Country { CountryCode = "ALA", CountryName = "Åland Islands" }

                    });
                    
                };
                context.SaveChanges();


                if (!context.PassportType.Any())
                {
                    context.PassportType.AddRange(new List<PassportType>
                    {
                        new PassportType { PassportTypeAbr = "P", PassportTypeDesc = "Citizen Passport"},
                        new PassportType { PassportTypeAbr = "PD", PassportTypeDesc = "Diplomatic Passport"},
                        new PassportType { PassportTypeAbr = "PS", PassportTypeDesc = "Service Passport"},
                        new PassportType { PassportTypeAbr = "PT", PassportTypeDesc = "Stateless Person Travel Document"},
                        new PassportType { PassportTypeAbr = "PR", PassportTypeDesc = "Refugee Travel Document"}
                    });
                }
                context.SaveChanges();


                // Seed Authorities
                if (!context.Authority.Any())
                    {
                        context.Authority.AddRange(new List<Authority>
                    {
                        new Authority {
                            AutorityId = 100,
                            CountryCode = "UKR",
                            City = "Kyiv",
                            Street = "Md.Nezalezhnoty",
                            HouseNum = "12",
                            Phone = "068678765434",
                            Email = "authority_100@example.com",
                            EstablishmentDate = new DateTime(2000, 1, 1) },
                        new Authority {
                            AutorityId = 101,
                            CountryCode = "FIN",
                            City = "Turku",
                            Street = "Queen St",
                            HouseNum = "202",
                            Phone = "9876543210",
                            Email = "authority_101@example.com",
                            EstablishmentDate = new DateTime(2005, 5, 5) },
                        new Authority {
                            AutorityId = 102,
                            CountryCode = "LTU",
                            City = "Kaunas",
                            Street = "Savanoriu",
                            HouseNum = "10",
                            Phone = "3706573864",
                            Email = "authority_102@example.com",
                            EstablishmentDate = new DateTime(2005, 5, 10) },
                        new Authority {
                            AutorityId = 103,
                            CountryCode = "POL",
                            City = "Krakow",
                            Street = "Nepoglegloshi",
                            HouseNum = "98",
                            Phone = "756485648",
                            Email = "authority_105@example.com",
                            EstablishmentDate = new DateTime(2005, 6, 10) },
                        new Authority {
                            AutorityId = 107,
                            CountryCode = "IRL",
                            City = "Dublin",
                            Street = "Inependence",
                            HouseNum = "18A",
                            Phone = "875487485",
                            Email = "authority_107@example.com",
                            EstablishmentDate = new DateTime(2005, 9, 30) },
                        new Authority {
                            AutorityId = 108,
                            CountryCode = "MDA",
                            City = "Chisinau",
                            Street = "Decebal",
                            HouseNum = "34",
                            Phone = "87545477547",
                            Email = "authority_108@example.com",
                            EstablishmentDate = new DateTime(2007, 01, 30) },
                        new Authority {
                            AutorityId = 109,
                            CountryCode = "GRL",
                            City = "Nuuk",
                            Street = "Imaneq",
                            HouseNum = "26",
                            Phone = "7857856784",
                            Email = "authority_109@example.com",
                            EstablishmentDate = new DateTime(2008, 01, 30) },
                    });
                        
                }
                context.SaveChanges();

                // Seed Passports
                if (!context.Passport.Any())
                    {
                        context.Passport.AddRange(new List<Passport>
                    {

                        new Passport
                        {
                            PassportId = 180808,
                            Type = "P",
                            IssueDate = new DateTime(2023, 7, 15),
                            ExpirationDate = new DateTime(2033, 7, 15),
                            AuthorityId = 100
                        },
                        new Passport
                        {
                            PassportId = 180809,
                            Type = "PD",
                            IssueDate = new DateTime(2024, 3, 1),
                            ExpirationDate = new DateTime(2034, 3, 1),
                            AuthorityId = 101
                        },
                        new Passport
                        {
                            PassportId = 180810,
                            Type = "PS",
                            IssueDate = new DateTime(2022, 10, 20),
                            ExpirationDate = new DateTime(2032, 10, 20),
                            AuthorityId = 102
                        },
                        new Passport
                        {
                            PassportId = 180811,
                            Type = "PT",
                            IssueDate = new DateTime(2023, 6, 5),
                            ExpirationDate = new DateTime(2033, 6, 5),
                            AuthorityId = 103
                        },
                        new Passport
                        {
                            PassportId = 180812,
                            Type = "PR",
                            IssueDate = new DateTime(2024, 11, 12),
                            ExpirationDate = new DateTime(2034, 11, 12),
                            AuthorityId = 107
                        },
                        new Passport
                        {
                            PassportId = 180813,
                            Type = "P",
                            IssueDate = new DateTime(2023, 4, 30),
                            ExpirationDate = new DateTime(2033, 4, 30),
                            AuthorityId = 108
                        },
                        new Passport
                        {
                            PassportId = 180814,
                            Type = "PD",
                            IssueDate = new DateTime(2022, 8, 7),
                            ExpirationDate = new DateTime(2032, 8, 7),
                            AuthorityId = 109
                        },
                        new Passport
                        {
                            PassportId = 180815,
                            Type = "PS",
                            IssueDate = new DateTime(2023, 12, 3),
                            ExpirationDate = new DateTime(2033, 12, 3),
                            AuthorityId = 100
                        },
                        new Passport
                        {
                            PassportId = 180816,
                            Type = "PT",
                            IssueDate = new DateTime(2024, 5, 22),
                            ExpirationDate = new DateTime(2034, 5, 22),
                            AuthorityId = 101
                        },
                        new Passport
                        {
                            PassportId = 180817,
                            Type = "PR",
                            IssueDate = new DateTime(2023, 9, 15),
                            ExpirationDate = new DateTime(2033, 9, 15),
                            AuthorityId = 102
                        },
                        new Passport
                        {
                            PassportId = 180818,
                            Type = "P",
                            IssueDate = new DateTime(2022, 12, 28),
                            ExpirationDate = new DateTime(2032, 12, 28),
                            AuthorityId = 103
                        },
                        new Passport
                        {
                            PassportId = 180819,
                            Type = "PD",
                            IssueDate = new DateTime(2023, 7, 10),
                            ExpirationDate = new DateTime(2033, 7, 10),
                            AuthorityId = 107
                        },
                        new Passport
                        {
                            PassportId = 180820,
                            Type = "PS",
                            IssueDate = new DateTime(2024, 2, 14),
                            ExpirationDate = new DateTime(2034, 2, 14),
                            AuthorityId = 108
                        },
                        new Passport
                        {
                            PassportId = 180821,
                            Type = "PT",
                            IssueDate = new DateTime(2023, 8, 26),
                            ExpirationDate = new DateTime(2033, 8, 26),
                            AuthorityId = 109
                        },
                        new Passport
                        {
                            PassportId = 180822,
                            Type = "PR",
                            IssueDate = new DateTime(2022, 11, 18),
                            ExpirationDate = new DateTime(2032, 11, 18),
                            AuthorityId = 100
                        },
                        new Passport
                        {
                            PassportId = 180823,
                            Type = "P",
                            IssueDate = new DateTime(2023, 6, 1),
                            ExpirationDate = new DateTime(2033, 6, 1),
                            AuthorityId = 101
                        },
                        new Passport
                        {
                            PassportId = 180824,
                            Type = "PD",
                            IssueDate = new DateTime(2024, 9, 9),
                            ExpirationDate = new DateTime(2034, 9, 9),
                            AuthorityId = 102
                        },
                        new Passport
                        {
                            PassportId = 180825,
                            Type = "PS",
                            IssueDate = new DateTime(2023, 3, 27),
                            ExpirationDate = new DateTime(2033, 3, 27),
                            AuthorityId = 103
                        },
                        new Passport
                        {
                            PassportId = 180826,
                            Type = "PT",
                            IssueDate = new DateTime(2022, 7, 12),
                            ExpirationDate = new DateTime(2032, 7, 12),
                            AuthorityId = 107
                        },
                        new Passport
                        {
                            PassportId = 180827,
                            Type = "PR",
                            IssueDate = new DateTime(2023, 10, 31),
                            ExpirationDate = new DateTime(2033, 10, 31),
                            AuthorityId = 108
                        },
                        new Passport
                        {
                            PassportId = 180828,
                            Type = "P",
                            IssueDate = new DateTime(2024, 4, 19),
                            ExpirationDate = new DateTime(2034, 4, 19),
                            AuthorityId = 109
                        },
                        new Passport
                        {
                            PassportId = 180829,
                            Type = "PD",
                            IssueDate = new DateTime(2023, 1, 5),
                            ExpirationDate = new DateTime(2033, 1, 5),
                            AuthorityId = 100
                        },
                        new Passport
                        {
                            PassportId = 180830,
                            Type = "PS",
                            IssueDate = new DateTime(2022, 6, 23),
                            ExpirationDate = new DateTime(2032, 6, 23),
                            AuthorityId = 101
                        },
                        new Passport
                        {
                            PassportId = 180831,
                            Type = "PT",
                            IssueDate = new DateTime(2023, 11, 14),
                            ExpirationDate = new DateTime(2033, 11, 14),
                            AuthorityId = 102
                        },
                        new Passport
                        {
                            PassportId = 180832,
                            Type = "PR",
                            IssueDate = new DateTime(2024, 8, 2),
                            ExpirationDate = new DateTime(2034, 8, 2),
                            AuthorityId = 103
                        },
                        new Passport
                        {
                            PassportId = 180833,
                            Type = "P",
                            IssueDate = new DateTime(2023, 5, 17),
                            ExpirationDate = new DateTime(2033, 5, 17),
                            AuthorityId = 107
                        },
                        new Passport
                        {
                            PassportId = 180834,
                            Type = "PD",
                            IssueDate = new DateTime(2022, 12, 9),
                            ExpirationDate = new DateTime(2032, 12, 9),
                            AuthorityId = 108
                        },
                        new Passport
                        {
                            PassportId = 180835,
                            Type = "PS",
                            IssueDate = new DateTime(2023, 9, 23),
                            ExpirationDate = new DateTime(2033, 9, 23),
                            AuthorityId = 109
                        }

                    });
                        context.SaveChanges();
                }

                    // Seed PassportHolders
                    if (!context.PassportsHolder.Any())
                    {
                        context.PassportsHolder.AddRange(new List<PassportHolder>
                    {

                        new PassportHolder //1
                        {
                            HolderId = 67547384, // need to exchange the HolderIds with PassportIds
                            PassportId = 180808,
                            HolderName = "Mykola",
                            HolderSurname = "Ivanenko",
                            PatronymicMatronymic = "Petrovych",
                            Birthday = new DateTime(2000, 5, 6),
                            BirthPlace = "Mykolaiv",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180808",
                            HolderPhoto = "photo180808.jpg"
                        },
                        new PassportHolder //2
                        {
                            HolderId = 67547493,
                            PassportId = 180809,
                            HolderName = "Olena",
                            HolderSurname = "Kovalenko",
                            PatronymicMatronymic = "Ivanivna",
                            Birthday = new DateTime(1995, 8, 15),
                            BirthPlace = "Lviv",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180809",
                            HolderPhoto = "photo180809.jpg"
                        },
                        new PassportHolder //3
                        {
                            HolderId = 67547621,
                            PassportId = 180810,
                            HolderName = "Andriy",
                            HolderSurname = "Shevchenko",
                            PatronymicMatronymic = "Ihoriovych",
                            Birthday = new DateTime(1988, 3, 22),
                            BirthPlace = "Poltava",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180810",
                            HolderPhoto = "photo180810.jpg"
                        },
                        new PassportHolder //4
                        {
                            HolderId = 67547755,
                            PassportId = 180811,
                            HolderName = "Iryna",
                            HolderSurname = "Bondarenko",
                            PatronymicMatronymic = "Oleksandrivna",
                            Birthday = new DateTime(1992, 11, 30),
                            BirthPlace = "Kharkiv",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180811",
                            HolderPhoto = "photo180811.jpg"
                        },
                        new PassportHolder //5
                        {
                            HolderId = 67547889,
                            PassportId = 180812,
                            HolderName = "Vasyl",
                            HolderSurname = "Melnyk",
                            PatronymicMatronymic = "Yuriiovych",
                            Birthday = new DateTime(1987, 7, 14),
                            BirthPlace = "Dnipro",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180812",
                            HolderPhoto = "photo180812.jpg"
                        },
                        new PassportHolder //6
                        {
                            HolderId = 67547932,
                            PassportId = 180813,
                            HolderName = "Sofia",
                            HolderSurname = "Kravchuk",
                            PatronymicMatronymic = "Oleksandrivna",
                            Birthday = new DateTime(1999, 4, 8),
                            BirthPlace = "Sumy",
                            SexAbr = "F",
                            Citizenship = "MDA",
                            Signature = "Signature180813",
                            HolderPhoto = "photo180813.jpg"
                        },
                        new PassportHolder //7
                        {
                            HolderId = 67548067,
                            PassportId = 180814,
                            HolderName = "Dmytro",
                            HolderSurname = "Lysenko",
                            PatronymicMatronymic = "Mykolayovych",
                            Birthday = new DateTime(1991, 9, 25),
                            BirthPlace = "Zhytomyr",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180814",
                            HolderPhoto = "photo180814.jpg"
                        },
                        new PassportHolder //8s
                        {
                            HolderId = 67548198,
                            PassportId = 180815,
                            HolderName = "Natalia",
                            HolderSurname = "Tkachenko",
                            PatronymicMatronymic = "Serhiivna",
                            Birthday = new DateTime(1997, 2, 17),
                            BirthPlace = "Chernihiv",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180815",
                            HolderPhoto = "photo180815.jpg"
                        },
                        new PassportHolder //9
                        {
                            HolderId = 67548312,
                            PassportId = 180816,
                            HolderName = "Oleksandr",
                            HolderSurname = "Pavlenko",
                            PatronymicMatronymic = "Volodymyrovych",
                            Birthday = new DateTime(1985, 6, 3),
                            BirthPlace = "Vinnytsia",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180816",
                            HolderPhoto = "photo180816.jpg"
                        },
                        new PassportHolder //10
                        {
                            HolderId = 67548445, 
                            PassportId = 180817,
                            HolderName = "Maria",
                            HolderSurname = "Kovalchuk",
                            PatronymicMatronymic = "Maksymivna",
                            Birthday = new DateTime(1994, 12, 11),
                            BirthPlace = "Rivne",
                            SexAbr = "F",
                            Citizenship = "POL",
                            Signature = "Signature180817",
                            HolderPhoto = "photo180817.jpg"
                        },
                        new PassportHolder //11
                        {
                            HolderId = 67548579,  
                            PassportId = 180818,
                            HolderName = "Ivan",
                            HolderSurname = "Serhiienko",
                            PatronymicMatronymic = "Andriiovych",
                            Birthday = new DateTime(1989, 10, 28),
                            BirthPlace = "Ternopil",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180818",
                            HolderPhoto = "photo180818.jpg"
                        },
                        new PassportHolder //12
                        {
                            HolderId = 67548712, 
                            PassportId = 180819,
                            HolderName = "Yulia",
                            HolderSurname = "Kozlova",
                            PatronymicMatronymic = "Mariivna",
                            Birthday = new DateTime(1996, 1, 19),
                            BirthPlace = "Lutsk",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180819",
                            HolderPhoto = "photo180819.jpg"
                        },
                        new PassportHolder //13
                        {
                            HolderId = 67548846,  
                            PassportId = 180820,
                            HolderName = "Serhii",
                            HolderSurname = "Honcharenko",
                            PatronymicMatronymic = "Oleksandrovych",
                            Birthday = new DateTime(1993, 5, 7),
                            BirthPlace = "Cherkasy",
                            SexAbr = "M",
                            Citizenship = "FIN",
                            Signature = "Signature180820",
                            HolderPhoto = "photo180820.jpg"
                        },
                        new PassportHolder //14
                        {
                            HolderId = 67548979,  
                            PassportId = 180821,
                            HolderName = "Tetiana",
                            HolderSurname = "Savchenko",
                            PatronymicMatronymic = "Anivna",
                            Birthday = new DateTime(1990, 8, 24),
                            BirthPlace = "Uzhhorod",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180821",
                            HolderPhoto = "photo180821.jpg"
                        },
                        new PassportHolder //15
                        {
                            HolderId = 67549112,
                            PassportId = 180822,
                            HolderName = "Volodymyr",
                            HolderSurname = "Zayets",
                            PatronymicMatronymic = "Ivanovych",
                            Birthday = new DateTime(1998, 3, 13),
                            BirthPlace = "Khmelnytskyi",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180822",
                            HolderPhoto = "photo180822.jpg"
                        },
                        new PassportHolder //16
                        {
                            HolderId = 67549245,  
                            PassportId = 180823,
                            HolderName = "Oksana",
                            HolderSurname = "Polishchuk",
                            PatronymicMatronymic = "Danylivna",
                            Birthday = new DateTime(1986, 11, 2),
                            BirthPlace = "Ivano-Frankivsk",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180823",
                            HolderPhoto = "photo180823.jpg"
                        },
                        new PassportHolder //17
                        {
                            HolderId = 67549378,  
                            PassportId = 180824,
                            HolderName = "Yuriy",
                            HolderSurname = "Kravets",
                            PatronymicMatronymic = "Dmytrovych",
                            Birthday = new DateTime(1992, 7, 21),
                            BirthPlace = "Kropyvnytskyi",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180824",
                            HolderPhoto = "photo180824.jpg"
                        },
                        new PassportHolder //18
                        {
                            HolderId = 67549511,  
                            PassportId = 180825,
                            HolderName = "Viktoria",
                            HolderSurname = "Shevchuk",
                            PatronymicMatronymic = "Markivna",
                            Birthday = new DateTime(1997, 4, 16),
                            BirthPlace = "Chernivtsi",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180825",
                            HolderPhoto = "photo180825.jpg"
                        },
                        new PassportHolder //19
                        {
                            HolderId = 67549644,
                            PassportId = 180826,
                            HolderName = "Maksym",
                            HolderSurname = "Kovalenko",
                            PatronymicMatronymic = "Sergiyovych",
                            Birthday = new DateTime(1991, 9, 9),
                            BirthPlace = "Zaporizhzhia",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180826",
                            HolderPhoto = "photo180826.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67549777,
                            PassportId = 180827,
                            HolderName = "Kateryna",
                            HolderSurname = "Bondar",
                            PatronymicMatronymic = "Darynivna",
                            Birthday = new DateTime(1995, 2, 28),
                            BirthPlace = "Kremenchuk",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180827",
                            HolderPhoto = "photo180827.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67549910,
                            PassportId = 180828,
                            HolderName = "Roman",
                            HolderSurname = "Marchenko",
                            PatronymicMatronymic = "Oleksiyovych",
                            Birthday = new DateTime(1988, 6, 14),
                            BirthPlace = "Bila Tserkva",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180828",
                            HolderPhoto = "photo180828.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67550043,
                            PassportId = 180829,
                            HolderName = "Alina",
                            HolderSurname = "Sydorenko",
                            PatronymicMatronymic = "Nazarivna",
                            Birthday = new DateTime(1999, 12, 5),
                            BirthPlace = "Melitopol",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180829",
                            HolderPhoto = "photo180829.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67550176,
                            PassportId = 180830,
                            HolderName = "Pavlo",
                            HolderSurname = "Kucherenko",
                            PatronymicMatronymic = "Vasylovych",
                            Birthday = new DateTime(1987, 10, 31),
                            BirthPlace = "Berdiansk",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180830",
                            HolderPhoto = "photo180830.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67550309,
                            PassportId = 180831,
                            HolderName = "Diana",
                            HolderSurname = "Petrenko",
                            PatronymicMatronymic = "Davydivna",
                            Birthday = new DateTime(1994, 1, 23),
                            BirthPlace = "Nikopol",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180831",
                            HolderPhoto = "photo180831.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67550442,
                            PassportId = 180832,
                            HolderName = "Taras",
                            HolderSurname = "Kovtun",
                            PatronymicMatronymic = "Mykhailovych",
                            Birthday = new DateTime(1990, 5, 18),
                            BirthPlace = "Uman",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180832",
                            HolderPhoto = "photo180832.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67550575,
                            PassportId = 180833,
                            HolderName = "Svitlana",
                            HolderSurname = "Kolomiiets",
                            PatronymicMatronymic = "Mykolaiivna",
                            Birthday = new DateTime(1996, 8, 7),
                            BirthPlace = "Brovary",
                            SexAbr = "F",
                            Citizenship = "FIN",
                            Signature = "Signature180833",
                            HolderPhoto = "photo180833.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67550708,
                            PassportId = 180834,
                            HolderName = "Ruslan",
                            HolderSurname = "Karpenko",
                            PatronymicMatronymic = "Andreevich",
                            Birthday = new DateTime(1993, 3, 12),
                            BirthPlace = "Drohobych",
                            SexAbr = "M",
                            Citizenship = "UKR",
                            Signature = "Signature180834",
                            HolderPhoto = "photo180834.jpg"
                        },
                        new PassportHolder
                        {
                            HolderId = 67550841,
                            PassportId = 180835,
                            HolderName = "Liudmyla",
                            HolderSurname = "Moroz",
                            PatronymicMatronymic = "Vasylivna",
                            Birthday = new DateTime(1989, 11, 29),
                            BirthPlace = "Dubai",
                            SexAbr = "F",
                            Citizenship = "UKR",
                            Signature = "Signature180835",
                            HolderPhoto = "photo180835.jpg"
                        }

                    });
                        
                    }
                    context.SaveChanges();

            }
            }
        }
    }


