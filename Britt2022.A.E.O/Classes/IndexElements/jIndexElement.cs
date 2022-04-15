namespace Britt2022.A.E.O.Classes.IndexElements
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class jIndexElement : IjIndexElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public jIndexElement(
            Location value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets the operating room.
        /// </summary>
        public Location Value { get; }
    }
}