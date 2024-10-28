namespace PatientForms.EF.Configurations.EntityTypeConfigurations;

internal class PatientEntityConfiguration : IEntityTypeConfiguration<Patient>
{
    public void Configure(EntityTypeBuilder<Patient> builder)
    {
        builder.Property(p => p.Name).HasColumnType("varchar(100)");
        builder.Property(p => p.ContactNumber).HasColumnType("varchar(30)");
    }
}
