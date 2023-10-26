namespace Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesFactory
    {
        IScenarioUtilizedTimes Create(
            ImmutableList<IScenarioUtilizedTimesResultElement> value);
    }
}