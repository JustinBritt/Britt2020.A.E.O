namespace Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface IxResultElement
    {
        IiIndexElement iIndexElement { get; }

        IjIndexElement jIndexElement { get; }

        IkIndexElement kIndexElement { get; }

        bool Value { get; }
    }
}