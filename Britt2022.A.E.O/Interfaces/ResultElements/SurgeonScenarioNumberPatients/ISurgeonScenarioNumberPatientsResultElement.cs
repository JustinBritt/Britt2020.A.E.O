namespace Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface ISurgeonScenarioNumberPatientsResultElement
    {
        IiIndexElement iIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        int Value { get; }
    }
}