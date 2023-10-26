namespace Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnutilizedTimes
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUnutilizedTimesResultElement
    {
        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}