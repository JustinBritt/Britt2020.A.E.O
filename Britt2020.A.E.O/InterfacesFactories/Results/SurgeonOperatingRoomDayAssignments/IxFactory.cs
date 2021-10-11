namespace Britt2020.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;

    public interface IxFactory
    {
        Ix Create(
            ImmutableList<IxResultElement> value);
    }
}