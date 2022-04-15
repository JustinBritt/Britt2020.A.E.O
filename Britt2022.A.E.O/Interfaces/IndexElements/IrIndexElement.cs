namespace Britt2022.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IrIndexElement
    {
        /// <summary>
        /// Gets the surgical specialty.
        /// </summary>
        Organization Value { get; }
    }
}