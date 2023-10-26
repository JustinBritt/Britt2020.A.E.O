namespace Britt2022.A.E.O.Classes.Calculations.ScenarioUtilizedTimes
{
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioUtilizedTimes;

    internal sealed class ScenarioUtilizedTimesResultElementCalculation : IScenarioUtilizedTimesResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioUtilizedTimesResultElementCalculation()
        {
        }

        public IScenarioUtilizedTimesResultElement Calculate(
            IScenarioUtilizedTimesResultElementFactory scenarioUtilizedTimesResultElementFactory,
            IωIndexElement ωIndexElement,
            Iijk srt,
            IA A,
            In n,
            Ix x)
        {
            return scenarioUtilizedTimesResultElementFactory.Create(
                ωIndexElement,
                srt.Value.Select(w =>
                x.GetElementAtAsint(
                    w.iIndexElement,
                    w.jIndexElement,
                    w.kIndexElement)
                *
                n.GetElementAtAsint(
                    w.iIndexElement,
                    ωIndexElement)
                *
                A.GetElementAtAsdecimal(
                    w.iIndexElement,
                    ωIndexElement))
                .Sum());
        }
    }
}