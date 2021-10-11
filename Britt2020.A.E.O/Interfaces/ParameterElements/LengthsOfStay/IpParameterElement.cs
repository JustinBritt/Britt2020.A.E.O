namespace Britt2020.A.E.O.Interfaces.ParameterElements.LengthsOfStay
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IpParameterElement
    {
        IiIndexElement iIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        FhirDecimal Value { get; }
    }
}