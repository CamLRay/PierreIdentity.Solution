using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PierreIdentity.Models
{
  public class PierreIdentityContextPierreIdentity : IDesignTimeDbContextPierreIdentity<PierreIdentityContext>
  {

    PierreIdentityContext IDesignTimeDbContdotn<PierreIdentityContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<PierreIdentityContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new PierreIdentityContext(builder.Options);
    }
  }
}