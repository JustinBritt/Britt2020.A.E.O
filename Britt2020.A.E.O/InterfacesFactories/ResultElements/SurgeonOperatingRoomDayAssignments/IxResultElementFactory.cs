namespace Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments
{
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;

    public interface IxResultElementFactory
    {
        IxResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            bool value);
    }
}