namespace Britt2022.A.E.O.InterfacesFactories.ParameterElements.StrategicTargets
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;

    public interface ILParameterElementFactory
    {
        ILParameterElement Create(
            IiIndexElement iIndexElement,
            INullableValue<int> value);
    }
}