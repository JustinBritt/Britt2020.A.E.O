namespace Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons
{
    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IΩParameterElement
    {
        IiIndexElement iIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        INullableValue<bool> Value { get; }
    }
}