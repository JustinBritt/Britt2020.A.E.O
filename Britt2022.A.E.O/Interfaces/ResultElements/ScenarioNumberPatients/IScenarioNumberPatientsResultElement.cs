namespace Britt2022.A.E.O.Interfaces.ResultElements.ScenarioNumberPatients
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IScenarioNumberPatientsResultElement
    {
        IωIndexElement ωIndexElement { get; }

        int Value { get; }
    }
}