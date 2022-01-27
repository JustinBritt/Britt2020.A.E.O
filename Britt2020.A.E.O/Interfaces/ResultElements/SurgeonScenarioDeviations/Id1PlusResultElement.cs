namespace Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface Id1PlusResultElement
    {
        IiIndexElement iIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        int Value { get; }
    }
}