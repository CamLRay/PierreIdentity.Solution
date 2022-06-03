using Microsoft.EntityFrameworkCore;

namespace PierreIdentity.Models
{
  public class PierreIdentityContext : DbContext
  {
    

    public PierreIdentityContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}