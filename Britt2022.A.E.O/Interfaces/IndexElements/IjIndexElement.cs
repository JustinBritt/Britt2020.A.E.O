namespace Britt2022.A.E.O.Interfaces.IndexElements
{
    using System;

    using Hl7.Fhir.Model;

    public interface IjIndexElement : IComparable<IjIndexElement>
    {
        /// <summary>
        /// Gets the operating room.
        /// </summary>
        Location Value { get; }
    }
}