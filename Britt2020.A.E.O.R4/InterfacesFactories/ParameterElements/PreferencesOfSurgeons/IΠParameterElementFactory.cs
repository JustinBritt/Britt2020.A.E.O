namespace Britt2020.A.E.O.InterfacesFactories.ParameterElements.PreferencesOfSurgeons
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;

    public interface IΠParameterElementFactory
    {
        IΠParameterElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            FhirBoolean value);
    }
}