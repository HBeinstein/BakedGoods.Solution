using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Factory.Models
{
  public class PastryFlavor
  {
    public int PastryFlavorId { get; set; }
    public int PastryId { get; set; }
    public int FlavorId { get; set; }
    public Flavor Flavor { get; set; }
    public Pastry Pastry { get; set; }
  }
}