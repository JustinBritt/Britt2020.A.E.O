namespace Britt2020.A.E.O.Classes.Contexts
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.Interfaces.Contexts;
    using Britt2020.A.E.O.Interfaces.Models;

    internal sealed class WGPMOutputContext : IWGPMOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMOutputContext(
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IWGPMModel WGPMModel,
            Solution solution)
        {
            // BestBound
            this.BestBound = resultsAbstractFactory.CreateBestBoundFactory().Create(
                (decimal)solution.BestBound)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // d1Minus(i, ω)
            this.SurgeonScenarioMinusDeviations = WGPMModel.d1Minus.GetElementsAt(
                resultElementsAbstractFactory.Created1MinusResultElementFactory(),
                resultsAbstractFactory.Created1MinusFactory(),
                WGPMModel.iω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // d1Plus(i, ω)
            this.SurgeonScenarioPlusDeviations = WGPMModel.d1Plus.GetElementsAt(
                resultElementsAbstractFactory.Created1PlusResultElementFactory(),
                resultsAbstractFactory.Created1PlusFactory(),
                WGPMModel.iω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // d2Minus(i, j, k, ω)
            this.SurgeonOperatingRoomDayScenarioDeviations = WGPMModel.d2Minus.GetElementsAt(
                resultElementsAbstractFactory.Created2MinusResultElementFactory(),
                resultsAbstractFactory.Created2MinusFactory(),
                WGPMModel.ijkω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // I(k, ω)
            this.DayScenarioRecoveryWardCensuses = WGPMModel.I.GetElementsAt(
                resultElementsAbstractFactory.CreateIResultElementFactory(),
                resultsAbstractFactory.CreateIFactory(),
                WGPMModel.kω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // IMax(ω)
            this.ScenarioRecoveryWardCensusMaximums = WGPMModel.IMax.GetElementsAt(
                resultElementsAbstractFactory.CreateIMaxResultElementFactory(),
                resultsAbstractFactory.CreateIMaxFactory(),
                WGPMModel.ω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // IMin(ω)
            this.ScenarioRecoveryWardCensusMinimums = WGPMModel.IMin.GetElementsAt(
                resultElementsAbstractFactory.CreateIMinResultElementFactory(),
                resultsAbstractFactory.CreateIMinFactory(),
                WGPMModel.ω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // NumberOfExploredNodes
            this.NumberOfExploredNodes = resultsAbstractFactory.CreateNumberOfExploredNodesFactory().Create(
                solution.NumberOfExploredNodes)
                .GetValueForOutputContext();

            // ObjectiveValue
            this.ObjectiveValue = resultsAbstractFactory.CreateObjectiveValueFactory().Create(
                (decimal)solution.ObjectiveValues.SingleOrDefault().Value)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // OverallWallTime
            this.OverallWallTime = resultsAbstractFactory.CreateOverallWallTimeFactory().Create(
                solution.OverallWallTime)
                .GetValueForOutputContext();

            // x(i, j, k)
            this.SurgeonOperatingRoomDayAssignments = WGPMModel.x.GetElementsAt(
                resultElementsAbstractFactory.CreatexResultElementFactory(),
                resultsAbstractFactory.CreatexFactory(),
                WGPMModel.ijk)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());
        }

        public INullableValue<decimal> BestBound { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioMinusDeviations { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> SurgeonScenarioPlusDeviations { get; }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<int>, INullableValue<decimal>>> SurgeonOperatingRoomDayScenarioDeviations { get; }

        public INullableValue<decimal> Gap { get; }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioRecoveryWardCensusMaximums { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> ScenarioRecoveryWardCensusMinimums { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> SurgeonOperatingRoomDayAssignments { get; }
    }
}