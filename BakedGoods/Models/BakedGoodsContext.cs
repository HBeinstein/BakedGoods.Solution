using Microsoft.EntityFrameworkCore;

namespace BakedGoods.Models
{
  public class BakedGoodsContext : DbContext
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public DbSet<Pastry> Pastries { get; set; }
    public DbSet<PastryFlavor> PastryFlavor { get; set; }

    public BakedGoodsContext(DbContextOptions options) : base(options) { }
  }
}