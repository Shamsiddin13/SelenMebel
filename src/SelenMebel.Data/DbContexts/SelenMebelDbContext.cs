using Microsoft.EntityFrameworkCore;
using SelenMebel.Domain.Entities;

namespace SelenMebel.Data.DbContexts;

public class SelenMebelDbContext : DbContext
{
    public SelenMebelDbContext(DbContextOptions<SelenMebelDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Furniture> Furnitures { get; set; }
    public DbSet<FurnitureFeature> FurnitureFeatures { get; set; }
    public DbSet<TypeOfFurniture> TypeOfFurnitures { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
