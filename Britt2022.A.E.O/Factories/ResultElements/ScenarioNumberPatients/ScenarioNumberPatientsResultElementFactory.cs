namespace Britt2022.A.E.O.Factories.ResultElements.ScenarioNumberPatients
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementFactory : IScenarioNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementFactory()
        {
        }

        public IScenarioNumberPatientsResultElement Create(
            IωIndexElement ωIndexElement,
            int value)
        {
            IScenarioNumberPatientsResultElement instance = null;

            try
            {
                instance = new ScenarioNumberPatientsResultElement(
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