namespace Britt2022.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class kIndexElement : IkIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public kIndexElement(
            int key,
            FhirDateTime value)
        {
            this.Key = key;

            this.Value = value;
        }

        /// <summary>
        /// Gets the key of the day.
        /// </summary>
        public int Key { get; }

        /// <summary>
        /// Gets the value of the day.
        /// </summary>
        public FhirDateTime Value { get; }
    }
}