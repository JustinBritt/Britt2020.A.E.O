namespace Britt2022.A.E.O.Classes.IndexElements
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class rIndexElement : IrIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public rIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public Organization Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IrIndexElement other)
        {
            return String.CompareOrdinal(
                other.Value.Id,
                this.Value.Id);
        }
    }
}