namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioTotalTimes
{
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;

    public interface IScenarioTotalTimesResultElementCalculation
    {
        IScenarioTotalTimesResultElement Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IωIndexElement ωIndexElement,
            Iijk ijk,
            Iv v,
            Ix x);
    }
}