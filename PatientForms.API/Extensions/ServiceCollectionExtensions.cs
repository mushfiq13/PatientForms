using PatientForms.API.Services;
using PatientForms.EF.Repositories.BaseRepository;

namespace PatientForms.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IRepository<Patient>, Repository<Patient>>();
        services.AddScoped<IRepository<Disease>, Repository<Disease>>();
        services.AddScoped<IRepository<NCD>, Repository<NCD>>();
        services.AddScoped<IRepository<Allergy>, Repository<Allergy>>();
        services.AddScoped<IRepository<PatientAllergy>, Repository<PatientAllergy>>();
        services.AddScoped<IRepository<PatientNCD>, Repository<PatientNCD>>();

        services.AddScoped<IPatientService, PatientService>();

        services.AddScoped<ICrudService<Patient>, CrudService<Patient>>();
        services.AddScoped<ICrudService<Disease>, CrudService<Disease>>();
        services.AddScoped<ICrudService<NCD>, CrudService<NCD>>();
        services.AddScoped<ICrudService<Allergy>, CrudService<Allergy>>();

        return services;
    }
}
