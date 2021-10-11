namespace Britt2020.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations;

    public interface Id2MinusFactory
    {
        Id2Minus Create(
            ImmutableList<Id2MinusResultElement> value);
    }
}