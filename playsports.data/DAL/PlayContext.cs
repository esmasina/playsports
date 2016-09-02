using playsports.data.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace playsports.data.DAL
{
    public class PlayContext : DbContext
    {
        public PlayContext() : base("PlayContext")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Attendance> Attendance { get; set; }
        public DbSet<Location> Locations { get; set; }

        //singular table names
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}