namespace Britt2022.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes
{
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;

    public interface IScenarioUtilizedTimesResultElementCalculation
    {
        IScenarioUtilizedTimesResultElement Calculate(
            IScenarioUtilizedTimesResultElementFactory scenarioUtilizedTimesResultElementFactory,
            IωIndexElement ωIndexElement,
            Iijk srt,
            IA A,
            In n,
            Ix x);
    }
}