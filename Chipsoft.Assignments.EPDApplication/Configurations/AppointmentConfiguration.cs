namespace Chipsoft.Assignments.EPDApplication.Configurations;

public class AppointmentConfiguration : IEntityTypeConfiguration<Appointment>
{
    public void Configure(EntityTypeBuilder<Appointment> builder)
    {
        builder.HasKey(v => v.Id);

        builder.HasOne(v => v.Patient).WithMany();
        builder.HasOne(v => v.Physician).WithMany();
    }
}