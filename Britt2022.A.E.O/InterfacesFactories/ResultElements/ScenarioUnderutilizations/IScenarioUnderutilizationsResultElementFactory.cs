namespace Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnderutilizations
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations;

    public interface IScenarioUnderutilizationsResultElementFactory
    {
        IScenarioUnderutilizationsResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value);
    }
}