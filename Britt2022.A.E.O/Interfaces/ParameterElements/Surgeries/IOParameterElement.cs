namespace Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IOParameterElement
    {
        IiIndexElement iIndexElement { get; }

        IeIndexElement eIndexElement { get; }

        FhirDecimal Value { get; }
    }
}