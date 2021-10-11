namespace Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations
{
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2MinusResultElementFactory
    {
        Id2MinusResultElement Create(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            decimal value);
    }
}