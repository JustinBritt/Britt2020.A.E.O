namespace Britt2022.A.E.O.Classes.Parameters.GoalWeights
{
    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;

    internal sealed class w1 : Iw1
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w1(
            FhirDecimal value)
        {
            this.Value = value;
        }

        public FhirDecimal Value { get; }
    }
}