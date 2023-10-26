namespace Britt2022.A.E.O.Factories.ResultElements.SurgeonScenarioNumberPatients
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElementFactory : ISurgeonScenarioNumberPatientsResultElementFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElementFactory()
        {
        }

        public ISurgeonScenarioNumberPatientsResultElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            int value)
        {
            ISurgeonScenarioNumberPatientsResultElement resultElement = null;

            try
            {
                resultElement = new SurgeonScenarioNumberPatientsResultElement(
                    iIndexElement,
                    ωIndexElement,
                    value);
            }
            catch (Exception exception)
            {
                this.Log.Error(
                    exception.Message,
                    exception);
            }

            return resultElement;
        }
    }
}