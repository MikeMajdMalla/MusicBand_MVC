using Microsoft.EntityFrameworkCore;

namespace MusicBand.Models
{
    public class BandContext : DbContext
    {
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Band> Bands { get; set; }


        //} 
        //SQL server 
        //public CarContext(DbContextOptions options) : base(options) 
        //{ 

        //SQLite 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=Bands.db");
        }
    }
}
