namespace Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioNumberPatients
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients;

    public interface IScenarioNumberPatientsResultElementFactory
    {
        IScenarioNumberPatientsResultElement Create(
            IωIndexElement ωIndexElement,
            int value);
    }
}