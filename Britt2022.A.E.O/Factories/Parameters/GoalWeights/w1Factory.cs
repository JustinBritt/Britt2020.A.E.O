namespace Britt2022.A.E.O.Factories.Parameters.GoalWeights
{
    using System;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Classes.Parameters.GoalWeights;
    using Britt2022.A.E.O.Interfaces.Parameters.GoalWeights;
    using Britt2022.A.E.O.InterfacesFactories.Parameters.GoalWeights;

    internal sealed class w1Factory : Iw1Factory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public w1Factory()
        {
        }

        public Iw1 Create(
            FhirDecimal value)
        {
            Iw1 parameter = null;

            try
            {
                parameter = new w1(
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