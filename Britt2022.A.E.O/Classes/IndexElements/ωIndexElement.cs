namespace Britt2022.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class ωIndexElement : IωIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ωIndexElement(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        /// <inheritdoc/>
        public INullableValue<int> Value { get; }

        /// <inheritdoc/>
        public int CompareTo(
            IωIndexElement other)
        {
            return this.Value.Value.Value.CompareTo(
                other.Value.Value.Value);
        }
    }
}