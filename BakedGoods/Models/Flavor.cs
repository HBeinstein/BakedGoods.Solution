using System.Collections.Generic;

namespace BakedGoods.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Pastries = new HashSet<PastryFlavor>();
    }

    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<PastryFlavor> Pastries { get; }
  }
}