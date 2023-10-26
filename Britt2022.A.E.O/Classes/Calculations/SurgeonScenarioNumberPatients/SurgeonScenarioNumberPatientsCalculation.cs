namespace Britt2022.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsCalculation : ISurgeonScenarioNumberPatientsCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsCalculation()
        {
        }

        public ISurgeonScenarioNumberPatients Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            ISurgeonScenarioNumberPatientsFactory surgeonScenarioNumberPatientsFactory,
            ISurgeonScenarioNumberPatientsResultElementCalculation surgeonScenarioNumberPatientsResultElementCalculation,
            Ijk jk,
            Iiω iω,
            In n,
            Ix x)
        {
            return surgeonScenarioNumberPatientsFactory.Create(
                iω.Value
                .Select(w => surgeonScenarioNumberPatientsResultElementCalculation.Calculate(
                    surgeonScenarioNumberPatientsResultElementFactory,
                    w.iIndexElement,
                    w.ωIndexElement,
                    jk,
                    n,
                    x))
                .ToImmutableList());
        }
    }
}