namespace Britt2020.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    internal sealed class eIndexElement : IeIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public eIndexElement(
            PositiveInt value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the cluster.
        /// </summary>
        public PositiveInt Value { get; }
    }
}