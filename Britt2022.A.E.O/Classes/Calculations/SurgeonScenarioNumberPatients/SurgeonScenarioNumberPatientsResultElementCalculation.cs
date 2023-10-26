namespace Britt2022.A.E.O.Classes.Calculations.SurgeonScenarioNumberPatients
{
    using System.Linq;

    using log4net;

    using Britt2022.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    internal sealed class SurgeonScenarioNumberPatientsResultElementCalculation : ISurgeonScenarioNumberPatientsResultElementCalculation
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonScenarioNumberPatientsResultElementCalculation()
        {
        }

        public ISurgeonScenarioNumberPatientsResultElement Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            Ijk jk,
            In n,
            Ix x)
        {
            return surgeonScenarioNumberPatientsResultElementFactory.Create(
                iIndexElement,
                ωIndexElement,
                jk.Value
                .Select(a =>
                x.GetElementAtAsint(
                    iIndexElement,
                    a.jIndexElement,
                    a.kIndexElement)
                *
                n.GetElementAtAsint(
                    iIndexElement,
                    ωIndexElement))
                .Sum());
        }
    }
}