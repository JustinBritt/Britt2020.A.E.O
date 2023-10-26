namespace Britt2022.A.E.O.Factories.Calculations.ScenarioNumberPatients
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Calculations.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementCalculationFactory : IScenarioNumberPatientsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementCalculationFactory()
        {
        }

        public IScenarioNumberPatientsResultElementCalculation Create()
        {
            IScenarioNumberPatientsResultElementCalculation instance = null;

            try
            {
                instance = new ScenarioNumberPatientsResultElementCalculation();
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