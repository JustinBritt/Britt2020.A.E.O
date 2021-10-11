namespace Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IBParameterElement
    {
        IrIndexElement rIndexElement { get; }

        PositiveInt Value { get; }
    }
}