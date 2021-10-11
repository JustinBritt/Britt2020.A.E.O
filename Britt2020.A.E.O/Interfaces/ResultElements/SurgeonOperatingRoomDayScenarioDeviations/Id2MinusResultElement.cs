namespace Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations
{
    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface Id2MinusResultElement
    {
        IiIndexElement iIndexElement { get; }

        IjIndexElement jIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        IωIndexElement ωIndexElement { get; }

        decimal Value { get; }
    }
}