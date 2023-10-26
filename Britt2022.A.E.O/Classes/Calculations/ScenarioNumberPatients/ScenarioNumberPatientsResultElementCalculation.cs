namespace Britt2022.A.E.O.Classes.Calculations.ScenarioNumberPatients
{
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsResultElementCalculation : IScenarioNumberPatientsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsResultElementCalculation()
        {
        }

        public IScenarioNumberPatientsResultElement Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IωIndexElement ωIndexElement,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients)
        {
            return scenarioNumberPatientsResultElementFactory.Create(
                ωIndexElement,
                surgeonScenarioNumberPatients.Value
                .Where(w => w.ωIndexElement == ωIndexElement)
                .Select(w => w.Value)
                .Sum());
        }
    }
}