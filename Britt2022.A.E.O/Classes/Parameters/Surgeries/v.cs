namespace Britt2022.A.E.O.Classes.Parameters.Surgeries
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;

    internal sealed class v : Iv
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public v(
            Duration value)
        {
            this.Value = value;
        }

        public Duration Value { get; }
    }
}