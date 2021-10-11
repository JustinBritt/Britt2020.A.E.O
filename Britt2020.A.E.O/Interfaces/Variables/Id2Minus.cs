namespace Britt2020.A.E.O.Interfaces.Variables
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2Minus
    {
        VariableCollection<IiIndexElement, IjIndexElement, IkIndexElement, IωIndexElement> Value { get; }

        decimal GetElementAt(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement);

        Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations.Id2Minus GetElementsAt(
            Id2MinusResultElementFactory d2MinusResultElementFactory,
            Id2MinusFactory d2MinusFactory,
            Iijkω ijkω);
    }
}