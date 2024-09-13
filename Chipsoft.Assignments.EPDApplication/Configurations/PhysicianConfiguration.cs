namespace Chipsoft.Assignments.EPDApplication.Configurations;

public class PhysicianConfiguration : IEntityTypeConfiguration<Physician>
{
    public void Configure(EntityTypeBuilder<Physician> builder)
    {
        builder.HasKey(v => v.Id);

        builder.HasOne(v => v.Address).WithMany();
    }
}