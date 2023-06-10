namespace Britt2022.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class lIndexElement : IlIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public lIndexElement(
            INullableValue<int> value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the day.
        /// </summary>
        public INullableValue<int> Value { get; }
    }
}