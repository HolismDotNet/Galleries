namespace Holism.Galleries.DataAccess;

public class GalleriesContext : DatabaseContext
{
    public override string ConnectionStringName => "Galleries";

    public DbSet<Gallery> Galleries { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
