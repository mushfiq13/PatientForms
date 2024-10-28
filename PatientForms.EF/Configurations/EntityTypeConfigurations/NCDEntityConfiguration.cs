namespace PatientForms.EF.Configurations.EntityTypeConfigurations;

internal class NcdEntityConfiguration : IEntityTypeConfiguration<NCD>
{
    public void Configure(EntityTypeBuilder<NCD> builder)
    {
        builder.Property(x => x.NcdName).HasColumnType("varchar(200)");
    }
}
