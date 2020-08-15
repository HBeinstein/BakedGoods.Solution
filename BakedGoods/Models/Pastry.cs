using System.Collections.Generic;

namespace BakedGoods.Models
{
  public class Pastry
  {
    public Pastry()
    {
      this.Flavors = new HashSet<PastryFlavor>();
    }

    public int PastryId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<PastryFlavor> Flavors { get; }
  }
}
