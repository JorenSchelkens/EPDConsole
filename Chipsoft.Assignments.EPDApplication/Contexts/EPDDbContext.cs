namespace Chipsoft.Assignments.EPDApplication.Contexts;

public class EPDDbContext : DbContext
{
    // The following configures EF to create a Sqlite database file in the
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=epd.db");

    public DbSet<Patient> Patients { get; set; }
}