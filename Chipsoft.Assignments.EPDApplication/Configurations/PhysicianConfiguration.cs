namespace Chipsoft.Assignments.EPDApplication.Configurations;

public class PhysicianConfiguration : IEntityTypeConfiguration<Physician>
{
    public void Configure(EntityTypeBuilder<Physician> builder)
    {
        builder.HasKey(v => v.Id);

        builder.Navigation(v => v.Address).AutoInclude();

        builder.HasOne(v => v.Address).WithMany();
    }
}