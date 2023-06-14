namespace Britt2022.A.E.O.InterfacesFactories.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.Contexts;

    public interface IWGPMInputContextFactory
    {
        IWGPMInputContext Create(
            ImmutableSortedSet<INullableValue<int>> clusters,
            Bundle surgeons,
            Bundle operatingRooms,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            RedBlackTree<Organization, INullableValue<int>> surgicalSpecialtyStrategicTargetNumberTimeBlocks,
            RedBlackTree<Organization, INullableValue<int>> surgeonMaximumNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumLengthsOfStay,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMinimumNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonStrategicTargetNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> surgeonScenarioMaximumNumberPatients,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> surgeonDayScenarioLengthOfStayProbabilities,
            Duration timeBlockLength,
            INullableValue<decimal> goalWeight1,
            INullableValue<decimal> goalWeight2,
            INullableValue<decimal> goalWeight3,
            INullableValue<decimal> goalWeight4,
            RedBlackTree<Organization, RedBlackTree<Location, INullableValue<bool>>> surgeonOperatingRoomAvailabilities,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            RedBlackTree<Organization, RedBlackTree<INullableValue<int>, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>> surgeonDayScenarioCumulativeNumberPatients,
            RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> surgeonDayAvailabilities);
    }
}