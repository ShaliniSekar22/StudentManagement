using Microsoft.EntityFrameworkCore;
using Student.Entity;

namespace Student.Context
{
  public class AppDbContext :DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
    {

    }
    public DbSet<SignUp> signUps { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<SignUp>().ToTable("signups");
    }
  }
  

}
