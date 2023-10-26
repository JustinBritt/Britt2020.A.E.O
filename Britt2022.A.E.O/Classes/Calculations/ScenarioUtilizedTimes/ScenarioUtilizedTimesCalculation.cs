namespace Britt2022.A.E.O.Classes.Calculations.ScenarioUtilizedTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesCalculation : IScenarioUtilizedTimesCalculation
    {
        public ScenarioUtilizedTimesCalculation()
        {
        }

        public IScenarioUtilizedTimes Calculate(
            IScenarioUtilizedTimesResultElementFactory scenarioUtilizedTimesResultElementFactory,
            IScenarioUtilizedTimesFactory scenarioUtilizedTimesFactory,
            IScenarioUtilizedTimesResultElementCalculation scenarioUtilizedTimesResultElementCalculation,
            Iω ω,
            Iijk ijk,
            IA A,
            In n,
            Ix x)
        {
            return scenarioUtilizedTimesFactory.Create(
                ω.Value.Values
                .Select(w => scenarioUtilizedTimesResultElementCalculation.Calculate(
                    scenarioUtilizedTimesResultElementFactory,
                    w,
                    ijk,
                    A,
                    n,
                    x))
                .ToImmutableList());
        }
    }
}