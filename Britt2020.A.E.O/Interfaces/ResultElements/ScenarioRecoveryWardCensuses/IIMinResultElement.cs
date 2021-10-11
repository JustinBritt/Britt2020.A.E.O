namespace Britt2020.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface IIMinResultElement
    {
        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}