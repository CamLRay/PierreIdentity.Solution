using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PierreIdentity.Models
{
  public class Treat
  {
    public Treat()
    {
      this.FlavorTreats = new HashSet<FlavorTreat>();
    }
    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreats { get;}
    
  }
}