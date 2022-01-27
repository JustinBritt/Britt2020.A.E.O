namespace Britt2020.A.E.O.Interfaces.Contexts
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    public interface IWGPMOutputContext
    {
        INullableValue<decimal> BestBound { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMinusDeviations { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioPlusDeviations { get; }

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<int>, INullableValue<decimal>>> SurgeonOperatingRoomDayScenarioDeviations { get; }

        INullableValue<decimal> Gap { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioRecoveryWardCensusMaximums { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioRecoveryWardCensusMinimums { get; }

        long NumberOfExploredNodes { get; }

        INullableValue<decimal> ObjectiveValue { get; }

        TimeSpan OverallWallTime { get; }

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> SurgeonOperatingRoomDayAssignments { get; }
    }
}