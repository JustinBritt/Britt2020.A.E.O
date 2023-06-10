namespace Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IBParameterElement
    {
        IrIndexElement rIndexElement { get; }

        INullableValue<int> Value { get; }
    }
}