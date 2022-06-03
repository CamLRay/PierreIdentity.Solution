using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PierreIdentity.Models
{
  public class Flavor
  {

    public Flavor()
    {
      this.TreatFlavors = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<TreatFlavor> TreatFlavors { get; }
    public virtual ApplicationUser User { get; set; }
  }
}