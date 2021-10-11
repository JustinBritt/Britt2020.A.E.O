namespace Britt2020.A.E.O.Interfaces.ParameterElements.LengthsOfStay
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IΦParameterElement
    {
        IiIndexElement iIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        FhirDecimal Value { get; }
    }
}