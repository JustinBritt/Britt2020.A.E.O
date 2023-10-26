namespace Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUtilizedTimesResultElement
    {
        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}