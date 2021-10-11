namespace Britt2020.A.E.O.InterfacesFactories.IndexElements
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IωIndexElementFactory
    {
        IωIndexElement Create(
            PositiveInt value);
    }
}