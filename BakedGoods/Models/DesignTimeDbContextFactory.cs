using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace BakedGoods.Models
{
  public class BakedGoodsContextBakedGoods : IDesignTimeDbContextBakedGoods<BakedGoodsContext>
  {

    BakedGoodsContext IDesignTimeDbContextBakedGoods<BakedGoodsContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<BakedGoodsContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new BakedGoodsContext(builder.Options);
    }
  }
}