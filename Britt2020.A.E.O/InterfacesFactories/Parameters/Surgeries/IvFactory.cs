namespace Britt2020.A.E.O.InterfacesFactories.Parameters.Surgeries
{
    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;

    public interface IvFactory
    {
        Iv Create(
            Duration value);
    }
}