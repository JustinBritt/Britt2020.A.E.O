namespace Britt2020.A.E.O.Interfaces.ParameterElements.LengthsOfStay
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IhParameterElement
    {
        IiIndexElement iIndexElement { get; }

        PositiveInt Value { get; }
    }
}