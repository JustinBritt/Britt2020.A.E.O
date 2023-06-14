namespace Britt2022.A.E.O.Factories.Results.SurgeonScenarioDeviations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    internal sealed class d1MinusFactory : Id1MinusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1MinusFactory()
        {
        }

        public Id1Minus Create(
            ImmutableList<Id1MinusResultElement> value)
        {
            Id1Minus instance = null;

            try
            {
                instance = new d1Minus(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return instance;
        }
    }
}