namespace Britt2020.A.E.O.InterfacesFactories.ParameterElements.ScenarioProbabilities
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IΡParameterElementFactory
    {
        IΡParameterElement Create(
            IωIndexElement ωIndexElement,
            FhirDecimal value);
    }
}