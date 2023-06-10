namespace Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IΡParameterElement
    {
        IωIndexElement ωIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}