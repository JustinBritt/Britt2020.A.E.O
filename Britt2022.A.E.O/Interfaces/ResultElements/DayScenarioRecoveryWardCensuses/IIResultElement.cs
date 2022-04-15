namespace Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IIResultElement
    {
        IkIndexElement kIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}