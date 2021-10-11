namespace Britt2020.A.E.O.Classes.Parameters.GoalWeights
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.Parameters.GoalWeights;

    internal sealed class w4 : Iw4
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w4(
            FhirDecimal value)
        {
            this.Value = value;
        }

        public FhirDecimal Value { get; }
    }
}