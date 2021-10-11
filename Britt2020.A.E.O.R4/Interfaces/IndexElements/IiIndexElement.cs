namespace Britt2020.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IiIndexElement
    {
        /// <summary>
        /// Gets the surgeon.
        /// </summary>
        Organization Value { get; }
    }
}