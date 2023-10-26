namespace Britt2022.A.E.O.Classes.Calculations.ScenarioTotalTimes
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesCalculation : IScenarioTotalTimesCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesCalculation()
        {
        }

        public IScenarioTotalTimes Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IScenarioTotalTimesFactory scenarioTotalTimesFactory,
            IScenarioTotalTimesResultElementCalculation scenarioTotalTimesResultElementCalculation,
            Iω Λ,
            Iijk ijk,
            Iv v,
            Ix x)
        {
            return scenarioTotalTimesFactory.Create(
                Λ.Value.Values
                .Select(w => scenarioTotalTimesResultElementCalculation.Calculate(
                    scenarioTotalTimesResultElementFactory,
                    w,
                    ijk,
                    v,
                    x))
                .ToImmutableList());
        }
    }
}