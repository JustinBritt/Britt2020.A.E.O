namespace Britt2022.A.E.O.Classes.Calculations.ScenarioNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;

    internal sealed class ScenarioNumberPatientsCalculation : IScenarioNumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioNumberPatientsCalculation()
        {
        }

        public IScenarioNumberPatients Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IScenarioNumberPatientsFactory scenarioNumberPatientsFactory,
            IScenarioNumberPatientsResultElementCalculation scenarioNumberPatientsResultElementCalculation,
            Iω ω,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients)
        {
            return scenarioNumberPatientsFactory.Create(
                ω.Value.Values
                    .Select(i => scenarioNumberPatientsResultElementCalculation.Calculate(
                        scenarioNumberPatientsResultElementFactory,
                        i,
                        surgeonScenarioNumberPatients))
                    .ToImmutableList());
        }
    }
}