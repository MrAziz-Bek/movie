namespace movie.Data;
public class MoviesDbContext : DbContext
{
    public DbSet<Movie> Movies { get; set; }

    public DbSet<Actor> Actors { get; set; }

    public DbSet<Genre> Genres { get; set; }

    public DbSet<Image> Images { get; set; }

    public MoviesDbContext(DbContextOptions options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Genre>().HasIndex(g => g.Name).IsUnique();
    }
}