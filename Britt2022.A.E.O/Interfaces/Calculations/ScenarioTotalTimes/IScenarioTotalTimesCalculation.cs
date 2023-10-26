namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioTotalTimes
{
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Results.ScenarioTotalTimes;

    public interface IScenarioTotalTimesCalculation
    {
        IScenarioTotalTimes Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IScenarioTotalTimesFactory scenarioTotalTimesFactory,
            IScenarioTotalTimesResultElementCalculation scenarioTotalTimesResultElementCalculation,
            Iω Λ,
            Iijk ijk,
            Iv v,
            Ix x);
    }
}