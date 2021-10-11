namespace Britt2020.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IΡParameterElement
    {
        IωIndexElement ωIndexElement { get; }

        FhirDecimal Value { get; }
    }
}