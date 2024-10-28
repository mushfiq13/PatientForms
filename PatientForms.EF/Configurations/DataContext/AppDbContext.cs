namespace PatientForms.EF.Configurations.DataContext;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Patient> Patients { get; init; }
    public DbSet<Disease> Diseases { get; init; }
    public DbSet<NCD> Ncds { get; init; }
    public DbSet<Allergy> Allergies { get; init; }
    public DbSet<PatientAllergy> PatientAllergies { get; init; }
    public DbSet<PatientNCD> PatientNcds { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}
