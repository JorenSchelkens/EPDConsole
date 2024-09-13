namespace Chipsoft.Assignments.EPDApplication.Contexts;

public class EPDDbContext : DbContext
{
    // The following configures EF to create a Sqlite database file in the
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source=epd.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(PatientConfiguration).Assembly);
    }

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Physician> Physicians { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}