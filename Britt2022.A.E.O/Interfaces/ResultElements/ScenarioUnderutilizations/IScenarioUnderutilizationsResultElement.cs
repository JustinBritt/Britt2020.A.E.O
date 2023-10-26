namespace Britt2022.A.E.O.Interfaces.ResultElements.ScenarioUnderutilizations
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IScenarioUnderutilizationsResultElement
    {
        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}