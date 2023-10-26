namespace Britt2022.A.E.O.Factories.ResultElements.ScenarioUnderutilizations
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsResultElementFactory : IScenarioUnderutilizationsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsResultElementFactory()
        {
        }

        public IScenarioUnderutilizationsResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value)
        {
            IScenarioUnderutilizationsResultElement instance = null;

            try
            {
                instance = new ScenarioUnderutilizationsResultElement(
                    ωIndexElement,
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