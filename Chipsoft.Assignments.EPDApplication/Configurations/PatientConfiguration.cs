namespace Chipsoft.Assignments.EPDApplication.Configurations;

public class PatientConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.HasKey(v => v.Id);

        builder.HasIndex(v => v.NationalRegistryNumber).IsUnique();

        builder.Navigation(v => v.Address).AutoInclude();

        builder.HasOne(v => v.Address).WithMany();
    }
}