namespace Britt2020.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IeIndexElement
    {
        /// <summary>
        /// Gets the cluster.
        /// </summary>
        PositiveInt Value { get; }
    }
}