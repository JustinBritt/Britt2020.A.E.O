namespace Britt2022.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IeIndexElement : IComparable<IeIndexElement>
    {
        /// <summary>
        /// Gets the cluster.
        /// </summary>
        INullableValue<int> Value { get; }
    }
}