using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PierreIdentity.Models
{
  public class Flavor
  {

    public Flavor()
    {
      this.FlavorTreats = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreats { get; }
  }
}