namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioNumberPatients
{
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsCalculation
    {
        IScenarioNumberPatients Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IScenarioNumberPatientsFactory scenarioNumberPatientsFactory,
            IScenarioNumberPatientsResultElementCalculation scenarioNumberPatientsResultElementCalculation,
            Iω ω,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients);
    }
}