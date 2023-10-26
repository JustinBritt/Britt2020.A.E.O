namespace Britt2022.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;

    public interface IScenarioTotalTimesFactory
    {
        IScenarioTotalTimes Create(
            ImmutableList<IScenarioTotalTimesResultElement> value);
    }
}