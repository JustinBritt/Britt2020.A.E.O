namespace Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IpParameterElement
    {
        IiIndexElement iIndexElement { get; }

        IlIndexElement lIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        INullableValue<decimal> Value { get; }
    }
}