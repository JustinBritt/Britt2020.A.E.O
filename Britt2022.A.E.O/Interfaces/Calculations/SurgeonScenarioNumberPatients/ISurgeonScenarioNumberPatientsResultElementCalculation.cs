namespace Britt2022.A.E.O.Interfaces.Calculations.SurgeonScenarioNumberPatients
{
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsResultElementCalculation
    {
        ISurgeonScenarioNumberPatientsResultElement Calculate(
            ISurgeonScenarioNumberPatientsResultElementFactory surgeonScenarioNumberPatientsResultElementFactory,
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            Ijk jk,
            In n,
            Ix x);
    }
}