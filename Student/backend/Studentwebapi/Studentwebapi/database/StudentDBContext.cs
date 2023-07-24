using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Studentwebapi.Models;

namespace Studentwebapi.database
{
  public class StudentDBContext : DbContext
  {
    public StudentDBContext(DbContextOptions options) : base(options)
    {
    }
    public DbSet<Students> Student { get; set; }
  }
}
