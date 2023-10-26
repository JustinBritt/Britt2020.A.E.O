namespace Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;

    public interface IScenarioTotalTimesResultElementFactory
    {
        IScenarioTotalTimesResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value);
    }
}