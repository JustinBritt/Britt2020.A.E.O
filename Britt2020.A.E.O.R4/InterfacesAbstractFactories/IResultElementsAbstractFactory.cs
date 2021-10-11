namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations;

    public interface IResultElementsAbstractFactory
    {
        Id1MinusResultElementFactory Created1MinusResultElementFactory();

        Id1PlusResultElementFactory Created1PlusResultElementFactory();

        Id2MinusResultElementFactory Created2MinusResultElementFactory();

        IIResultElementFactory CreateIResultElementFactory();

        IIMaxResultElementFactory CreateIMaxResultElementFactory();

        IIMinResultElementFactory CreateIMinResultElementFactory();

        IxResultElementFactory CreatexResultElementFactory();
    }
}