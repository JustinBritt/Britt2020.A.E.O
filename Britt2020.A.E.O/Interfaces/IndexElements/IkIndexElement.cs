namespace Britt2020.A.E.O.Interfaces.IndexElements
{
    using Hl7.Fhir.Model;

    public interface IkIndexElement
    {
        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        FhirDateTime Value { get; }
    }
}