namespace Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IhParameterElement
    {
        IiIndexElement iIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}