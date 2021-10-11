namespace Britt2020.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IjIndexElement
    {
        /// <summary>
        /// Gets the operating room.
        /// </summary>
        Location Value { get; }
    }
}