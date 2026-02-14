using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;

namespace eShopSolution.Data.EF;

public class EShopDbContext: DbContext
{
    public EShopDbContext(DbContextOptions<EShopDbContext> options) 
        : base(options) { }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}