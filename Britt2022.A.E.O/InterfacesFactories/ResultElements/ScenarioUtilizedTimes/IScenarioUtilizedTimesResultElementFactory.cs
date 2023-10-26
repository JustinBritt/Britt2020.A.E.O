namespace Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesResultElementFactory
    {
        IScenarioUtilizedTimesResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value);
    }
}