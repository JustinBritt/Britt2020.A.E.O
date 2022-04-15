namespace Britt2022.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;

    public interface IIFactory
    {
        II Create(
            ImmutableList<IIResultElement> value);
    }
}