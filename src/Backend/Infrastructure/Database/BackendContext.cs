namespace Backend.Infrastructure.Database;

public class BackendContext : DbContext
{
    public DbSet<Supplier> Suppliers => Set<Supplier>();

    public BackendContext(DbContextOptions<BackendContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SupplierConfiguration());
        base.OnModelCreating(modelBuilder);
    }

    public void Seed()
    {
        new SupplierSeeding(this).Seed();
    }
}