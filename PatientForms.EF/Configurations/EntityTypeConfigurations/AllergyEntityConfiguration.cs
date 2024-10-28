namespace PatientForms.EF.Configurations.EntityTypeConfigurations;

internal class AllergyEntityConfiguration : IEntityTypeConfiguration<Allergy>
{
    public void Configure(EntityTypeBuilder<Allergy> builder)
    {
        builder.Property(x => x.AllergyName).HasColumnType("varchar(100)");
    }
}
