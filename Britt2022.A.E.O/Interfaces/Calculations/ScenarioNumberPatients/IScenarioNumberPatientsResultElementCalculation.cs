namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioNumberPatients
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsResultElementCalculation
    {
        IScenarioNumberPatientsResultElement Calculate(
            IScenarioNumberPatientsResultElementFactory scenarioNumberPatientsResultElementFactory,
            IωIndexElement ωIndexElement,
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients);
    }
}