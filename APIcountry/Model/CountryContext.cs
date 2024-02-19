using Microsoft.EntityFrameworkCore;


namespace APIcountry.Model
{
    public class CountryContext : DbContext 
    {
        public DbSet<Country> Countries { get; set; }
        


        //} 
        //SQL server 
        //public CarContext(DbContextOptions options) : base(options) 
        //{ 

        //SQLite 
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=Country.db");
        }

    }
}

