namespace Britt2022.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class iIndexElement : IiIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public iIndexElement(
            Organization value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the surgeon.
        /// </summary>
        public Organization Value { get; }
    }
}