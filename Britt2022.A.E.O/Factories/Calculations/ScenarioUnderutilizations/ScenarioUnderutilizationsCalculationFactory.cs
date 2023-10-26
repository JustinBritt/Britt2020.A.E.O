namespace Britt2022.A.E.O.Factories.Calculations.ScenarioUnderutilizations
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Calculations.ScenarioUnderutilizations;
    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUnderutilizations;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioUnderutilizations;

    internal sealed class ScenarioUnderutilizationsCalculationFactory : IScenarioUnderutilizationsCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUnderutilizationsCalculationFactory()
        {
        }

        public IScenarioUnderutilizationsCalculation Create()
        {
            IScenarioUnderutilizationsCalculation instance = null;

            try
            {
                instance = new ScenarioUnderutilizationsCalculation();
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