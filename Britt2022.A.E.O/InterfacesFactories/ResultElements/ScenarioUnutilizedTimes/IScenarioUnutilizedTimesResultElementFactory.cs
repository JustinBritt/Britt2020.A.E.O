namespace Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUnutilizedTimes
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes;

    public interface IScenarioUnutilizedTimesResultElementFactory
    {
        IScenarioUnutilizedTimesResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value);
    }
}