namespace Galleries;

public class GalleriesContext : DatabaseContext
{
    public override string ConnectionStringName => "Galleries";

    public DbSet<Galleries.Gallery> Galleries { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
