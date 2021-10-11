namespace Britt2020.A.E.O.Factories.Results.SurgeonScenarioDeviations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2020.A.E.O.Classes.Results.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    internal sealed class d1PlusFactory : Id1PlusFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1PlusFactory()
        {
        }

        public Id1Plus Create(
            ImmutableList<Id1PlusResultElement> value)
        {
            Id1Plus result = null;

            try
            {
                result = new d1Plus(
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return result;
        }
    }
}