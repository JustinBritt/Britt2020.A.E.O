namespace Britt2022.A.E.O.Classes.Calculations.ScenarioTotalTimes
{
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.ScenarioTotalTimes;

    internal sealed class ScenarioTotalTimesResultElementCalculation : IScenarioTotalTimesResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public ScenarioTotalTimesResultElementCalculation()
        {
        }

        public IScenarioTotalTimesResultElement Calculate(
            IScenarioTotalTimesResultElementFactory scenarioTotalTimesResultElementFactory,
            IωIndexElement ωIndexElement,
            Iijk ijk,
            Iv v,
            Ix x)
        {
            return scenarioTotalTimesResultElementFactory.Create(
                ωIndexElement,
                ijk.Value.Select(w =>
                x.GetElementAtAsint(
                    w.iIndexElement,
                    w.jIndexElement,
                    w.kIndexElement)
                *
                v.Value.Value.Value)
                .Sum());
        }
    }
}