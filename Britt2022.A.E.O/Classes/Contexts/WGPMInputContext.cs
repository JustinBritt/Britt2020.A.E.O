namespace Britt2022.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Immutable;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.Contexts;

    public sealed class WGPMInputContext : IWGPMInputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMInputContext(
            ImmutableSortedSet<INullableValue<int>> clusters,
            Bundle surgeons,
            Bundle operatingRooms,
            RedBlackTree<INullableValue<int>, FhirDateTime> planningHorizon,
            ImmutableSortedSet<INullableValue<int>> lengthOfStayDays,
            RedBlackTree<Organization, ImmutableSortedSet<Organization>> surgicalSpecialties,
            ImmutableSortedSet<INullableValue<int>> scenarios,
            ImmutableList<Tuple<Organization, PositiveInt, Duration>> surgeonScenarioWeightedAverageSurgicalDurations,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgicalSpecialtyStrategicTargetNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMaximumLengthsOfStay,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonMinimumNumberTimeBlocks,
            ImmutableList<KeyValuePair<Organization, PositiveInt>> surgeonStrategicTargetNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> surgeonScenarioMaximumNumberPatients,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioLengthOfStayProbabilities,
            Duration timeBlockLength,
            INullableValue<decimal> goalWeight1,
            INullableValue<decimal> goalWeight2,
            INullableValue<decimal> goalWeight3,
            INullableValue<decimal> goalWeight4,
            ImmutableList<Tuple<Organization, Location, FhirBoolean>> surgeonOperatingRoomAvailabilities,
            RedBlackTree<INullableValue<int>, INullableValue<decimal>> scenarioProbabilities,
            ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> surgeonDayScenarioCumulativeNumberPatients,
            RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> surgeonDayAvailabilities)
        {
            // e
            this.Clusters = clusters;

            // i
            this.Surgeons = surgeons;

            // j
            this.OperatingRooms = operatingRooms;

            // k
            this.PlanningHorizon = planningHorizon;

            // l
            this.LengthOfStayDays = lengthOfStayDays;

            // r
            this.SurgicalSpecialties = surgicalSpecialties;

            // ω
            this.Scenarios = scenarios;

            // A(i, ω)
            if (surgeonScenarioWeightedAverageSurgicalDurations != null)
            {
                this.SurgeonScenarioWeightedAverageSurgicalDurations = surgeonScenarioWeightedAverageSurgicalDurations;
            }    
            
            // B(r)
            this.SurgicalSpecialtyStrategicTargetNumberTimeBlocks = surgicalSpecialtyStrategicTargetNumberTimeBlocks;

            // H(i)
            this.SurgeonMaximumNumberTimeBlocks = surgeonMaximumNumberTimeBlocks;

            // h(i)
            this.SurgeonMaximumLengthsOfStay = surgeonMaximumLengthsOfStay;

            // L(i)
            this.SurgeonMinimumNumberTimeBlocks = surgeonMinimumNumberTimeBlocks;

            // N(i)
            this.SurgeonStrategicTargetNumberPatients = surgeonStrategicTargetNumberPatients;

            // n(i, ω)
            this.SurgeonScenarioMaximumNumberPatients = surgeonScenarioMaximumNumberPatients;

            // p(i, l, ω)
            if (surgeonDayScenarioLengthOfStayProbabilities != null)
            {
                this.SurgeonDayScenarioLengthOfStayProbabilities = surgeonDayScenarioLengthOfStayProbabilities;
            }

            // v
            this.TimeBlockLength = timeBlockLength;

            // w1
            this.GoalWeight1 = goalWeight1;

            // w2
            this.GoalWeight2 = goalWeight2;
            
            // w3
            this.GoalWeight3 = goalWeight3;

            // w4
            this.GoalWeight4 = goalWeight4;

            this.SurgeonOperatingRoomAvailabilities = surgeonOperatingRoomAvailabilities;

            this.ScenarioProbabilities = scenarioProbabilities;

            this.SurgeonDayScenarioCumulativeNumberPatients = surgeonDayScenarioCumulativeNumberPatients;

            // Ω(i, k)
            this.SurgeonDayAvailabilities = surgeonDayAvailabilities;
        }

        /// <summary>
        /// Gets the clusters.
        /// Parameter: e
        /// </summary>
        public ImmutableSortedSet<INullableValue<int>> Clusters { get; }

        /// <summary>
        /// Gets the surgeons.
        /// Parameter: i
        /// </summary>
        public Bundle Surgeons { get; }

        /// <summary>
        /// Gets the operating rooms.
        /// Parameter: j
        /// </summary>
        public Bundle OperatingRooms { get; }

        public RedBlackTree<INullableValue<int>, FhirDateTime> PlanningHorizon { get; }

        /// <summary>
        /// Gets the length of stay days.
        /// Parameter: l
        /// </summary>
        public ImmutableSortedSet<INullableValue<int>> LengthOfStayDays { get; }

        /// <summary>
        /// Gets the surgical specialties
        /// Parameter: r
        /// </summary>
        public RedBlackTree<Organization, ImmutableSortedSet<Organization>> SurgicalSpecialties { get; }

        /// <summary>
        /// Gets the scenarios
        /// Parameter: ω
        /// </summary>
        public ImmutableSortedSet<INullableValue<int>> Scenarios { get; }

        /// <summary>
        /// 
        /// Parameter: A
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, Duration>> SurgeonScenarioWeightedAverageSurgicalDurations { get; }

        /// <summary>
        /// 
        /// Parameter: B
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgicalSpecialtyStrategicTargetNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: H
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: h
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMaximumLengthsOfStay { get; }

        /// <summary>
        /// 
        /// Parameter: L
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonMinimumNumberTimeBlocks { get; }

        /// <summary>
        /// 
        /// Parameter: N
        /// </summary>
        public ImmutableList<KeyValuePair<Organization, PositiveInt>> SurgeonStrategicTargetNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: n
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt>> SurgeonScenarioMaximumNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: p
        /// </summary>
        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioLengthOfStayProbabilities { get; }

        /// <summary>
        /// Gets the time block length.
        /// Parameter: v
        /// </summary>
        public Duration TimeBlockLength { get; }

        /// <summary>
        /// 
        /// Parameter: w1
        /// </summary>
        public INullableValue<decimal> GoalWeight1 { get; }

        /// <summary>
        /// 
        /// Parameter: w2
        /// </summary>
        public INullableValue<decimal> GoalWeight2 { get; }

        /// <summary>
        /// 
        /// Parameter: w3
        /// </summary>
        public INullableValue<decimal> GoalWeight3 { get; }

        /// <summary>
        /// 
        /// Parameter: w4
        /// </summary>
        public INullableValue<decimal> GoalWeight4 { get; }

        /// <summary>
        /// 
        /// Parameter: Π
        /// </summary>
        public ImmutableList<Tuple<Organization, Location, FhirBoolean>> SurgeonOperatingRoomAvailabilities { get; }

        /// <summary>
        /// 
        /// Parameter: Ρ
        /// </summary>
        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioProbabilities { get; }

        public ImmutableList<Tuple<Organization, PositiveInt, PositiveInt, FhirDecimal>> SurgeonDayScenarioCumulativeNumberPatients { get; }

        /// <summary>
        /// 
        /// Parameter: Ω
        /// </summary>
        public RedBlackTree<Organization, RedBlackTree<FhirDateTime, INullableValue<bool>>> SurgeonDayAvailabilities { get; }
    }
}