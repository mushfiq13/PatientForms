namespace PatientForms.API.Models;

public record struct PatientBindingModel(
    string Name,
    string ContactNumber,
    int DiseaseId,
    Epilepsy Epilepsy,
    List<int> Ncds,
    List<int> Allergies
);