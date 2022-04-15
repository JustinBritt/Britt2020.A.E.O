namespace Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IIMaxResultElement
    {
        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}