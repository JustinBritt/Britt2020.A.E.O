namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Results.BestBound;
    using Britt2020.A.E.O.InterfacesFactories.Results.DayScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Results.Gap;
    using Britt2020.A.E.O.InterfacesFactories.Results.NumberOfExploredNodes;
    using Britt2020.A.E.O.InterfacesFactories.Results.ObjectiveValue;
    using Britt2020.A.E.O.InterfacesFactories.Results.OverallWallTime;
    using Britt2020.A.E.O.InterfacesFactories.Results.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations;

    public interface IResultsAbstractFactory
    {
        IBestBoundFactory CreateBestBoundFactory();

        Id1MinusFactory Created1MinusFactory();

        Id1PlusFactory Created1PlusFactory();

        Id2MinusFactory Created2MinusFactory();

        IGapFactory CreateGapFactory();

        IIFactory CreateIFactory();

        IIMaxFactory CreateIMaxFactory();

        IIMinFactory CreateIMinFactory();

        INumberOfExploredNodesFactory CreateNumberOfExploredNodesFactory();

        IObjectiveValueFactory CreateObjectiveValueFactory();

        IOverallWallTimeFactory CreateOverallWallTimeFactory();

        IxFactory CreatexFactory();
    }
}