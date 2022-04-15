namespace Britt2022.A.E.O.InterfacesFactories.Parameters.GoalWeights
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;

    public interface Iw3Factory
    {
        Iw3 Create(
            FhirDecimal value);
    }
}