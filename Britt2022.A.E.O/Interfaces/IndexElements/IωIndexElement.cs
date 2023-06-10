namespace Britt2022.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IωIndexElement
    {
        /// <summary>
        /// Gets the scenario.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}