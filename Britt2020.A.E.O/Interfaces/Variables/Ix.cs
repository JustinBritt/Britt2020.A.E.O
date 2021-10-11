namespace Britt2020.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;

    public interface Ix
    {
        VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement> Value { get; }

        bool GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement);

        Interfaces.Results.SurgeonOperatingRoomDayAssignments.Ix GetElementsAt(
            IxResultElementFactory xResultElementFactory,
            IxFactory xFactory,
            Iijk ijk);
    }
}