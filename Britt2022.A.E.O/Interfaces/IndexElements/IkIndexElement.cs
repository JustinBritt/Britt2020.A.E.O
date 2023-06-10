namespace Britt2022.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IkIndexElement : IComparable<IkIndexElement>
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