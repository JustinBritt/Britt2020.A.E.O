namespace Britt2022.A.E.O.Factories.Calculations.SurgeonScenarioNumberPatients
{
    using System;

    using log4net;

    using Britt2022.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Calculations.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElementCalculationFactory : ISurgeonScenarioNumberPatientsResultElementCalculationFactory
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElementCalculationFactory()
        {
        }

        public ISurgeonScenarioNumberPatientsResultElementCalculation Create()
        {
            ISurgeonScenarioNumberPatientsResultElementCalculation instance = null;

            try
            {
                instance = new SurgeonScenarioNumberPatientsResultElementCalculation();
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