using Microsoft.EntityFrameworkCore;
namespace assignment_products_categories.Models
{
  public class MyContext : DbContext
  {
    public MyContext(DbContextOptions options) : base(options) { }
    public DbSet<Product> Products { get; set; }
    public DbSet<Association> Associations { get; set; }
    public DbSet<Category> Categories { get; set; }
  }
}