namespace Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface ILParameterElement
    {
        IiIndexElement iIndexElement { get; }

        PositiveInt Value { get; }
    }
}