namespace Britt2022.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IrIndexElement : IComparable<IrIndexElement>
    {
        /// <summary>
        /// Gets the surgical specialty.
        /// </summary>
        Organization Value { get; }
    }
}