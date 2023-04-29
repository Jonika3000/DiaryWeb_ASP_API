using Dairy.Models;
using Microsoft.EntityFrameworkCore;

namespace API
{
    public class ApplicationContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<Emotions> Eemotions { get; set; }
        public DbSet<Hobbies> Hobbies { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Weather> Weathers { get; set; }
        public ApplicationContext(DbContextOptions options)
: base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-57UKIQP;Initial Catalog=Diary;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }


    }
}
