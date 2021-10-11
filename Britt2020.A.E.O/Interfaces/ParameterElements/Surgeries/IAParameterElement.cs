namespace Britt2020.A.E.O.Interfaces.ParameterElements.Surgeries
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IAParameterElement
    {
        IiIndexElement iIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        Duration Value { get; }
    }
}