namespace Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IScenarioTotalTimesResultElement
    {
        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}