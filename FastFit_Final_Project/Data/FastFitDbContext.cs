using Fast_Fit_Final_Project.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Fast_Fit_Final_Project.Data
{
    public class FastFitDbContext : DbContext
    {
        public DbSet<Members> Members { get; set; }
        public DbSet<FemaleShoe> FemaleShoe { get; set; }
        public DbSet<MaleShoe> MaleShoe { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }

        public FastFitDbContext(DbContextOptions<FastFitDbContext> options)
            : base(options)
        {
        }

       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EventTag>().HasKey(et => new { et.EventId, et.TagId });
        }*/
    

}
}
