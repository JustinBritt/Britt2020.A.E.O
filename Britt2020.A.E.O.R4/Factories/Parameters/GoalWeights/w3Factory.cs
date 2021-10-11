namespace Britt2020.A.E.O.Factories.Parameters.GoalWeights
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Classes.Parameters.GoalWeights;
    using Britt2020.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2020.A.E.O.InterfacesFactories.Parameters.GoalWeights;

    internal sealed class w3Factory : Iw3Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w3Factory()
        {
        }

        public Iw3 Create(
            FhirDecimal value)
        {
            Iw3 parameter = null;

            try
            {
                parameter = new w3(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return parameter;
        }
    }
}