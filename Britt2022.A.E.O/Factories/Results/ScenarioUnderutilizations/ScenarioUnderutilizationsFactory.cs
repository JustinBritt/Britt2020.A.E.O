namespace Britt2022.A.E.O.Factories.Results.ScenarioUnderutilizations
{
    using System;
    using System.Collections.Immutable;

    using log4net;

    using Britt2022.A.E.O.Classes.Results.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsFactory : IScenarioUnderutilizationsFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsFactory()
        {
        }

        public IScenarioUnderutilizations Create(
            ImmutableList<IScenarioUnderutilizationsResultElement> value)
        {
            IScenarioUnderutilizations instance = null;

            try
            {
                instance = new ScenarioUnderutilizations(
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