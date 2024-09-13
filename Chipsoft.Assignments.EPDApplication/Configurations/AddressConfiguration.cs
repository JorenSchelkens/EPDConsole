namespace Chipsoft.Assignments.EPDApplication.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(v => v.Id);
    }
}