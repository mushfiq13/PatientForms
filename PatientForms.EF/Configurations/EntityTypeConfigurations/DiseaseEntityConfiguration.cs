namespace PatientForms.EF.Configurations.EntityTypeConfigurations;

internal class DiseaseEntityConfiguration : IEntityTypeConfiguration<Disease>
{
    public void Configure(EntityTypeBuilder<Disease> builder)
    {
        builder.Property(p => p.DiseaseName).HasColumnType("varchar(100)");
    }
}