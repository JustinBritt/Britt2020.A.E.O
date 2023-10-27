namespace Britt2022.A.E.O.Interfaces.Contexts
{
    using System;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    public interface IWGPMOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioMinusDeviations { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioPlusDeviations { get; }

        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> SurgeonOperatingRoomDayScenarioDeviations { get; }

        INullableValue<decimal> Gap { get; }

        RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioRecoveryWardCensusMaximums { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioRecoveryWardCensusMinimums { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        RedBlackTree<INullableValue<int>, INullableValue<int>> ScenarioNumberPatients { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalTimes { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnderutilizations { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnutilizedTimes { get; }

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUtilizedTimes { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> SurgeonOperatingRoomDayAssignments { get; }
    }
}