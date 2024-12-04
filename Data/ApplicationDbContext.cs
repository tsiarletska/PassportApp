using Microsoft.EntityFrameworkCore;
using PassportsApp.Models;

namespace PassportsApp.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Sex>? Sex { get; set; }
        public DbSet<Country>? Country { get; set; }
        public DbSet<PassportType>? PassportType { get; set; }
        public DbSet<Authority>? Authority { get; set; }
        public DbSet<Passport>? Passport { get; set; }
        public DbSet<PassportHolder>? PassportsHolder { get; set; }
        
        
    }





    }

