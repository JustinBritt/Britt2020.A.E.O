namespace Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    public interface IΦParameterElementFactory
    {
        IΦParameterElement Create(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement,
            INullableValue<decimal> value);
    }
}