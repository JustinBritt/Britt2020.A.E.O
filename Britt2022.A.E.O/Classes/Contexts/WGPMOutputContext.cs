namespace Britt2022.A.E.O.Classes.Contexts
{
    using System;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.Interfaces.Contexts;
    using Britt2022.A.E.O.Interfaces.Models;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUnutilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioUtilizedTimes;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;
    
    internal sealed class WGPMOutputContext : IWGPMOutputContext
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public WGPMOutputContext(
            ICalculationsAbstractFactory calculationsAbstractFactory,
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
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultElementsAbstractFactory.Created1MinusResultElementFactory(),
                resultsAbstractFactory.Created1MinusFactory(),
                WGPMModel.i,
                WGPMModel.ω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // d1Plus(i, ω)
            this.SurgeonScenarioPlusDeviations = WGPMModel.d1Plus.GetElementsAt(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultElementsAbstractFactory.Created1PlusResultElementFactory(),
                resultsAbstractFactory.Created1PlusFactory(),
                WGPMModel.i,
                WGPMModel.ω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // d2Minus(i, j, k, ω)
            this.SurgeonOperatingRoomDayScenarioDeviations = WGPMModel.d2Minus.GetElementsAt(
                resultElementsAbstractFactory.Created2MinusResultElementFactory(),
                resultsAbstractFactory.Created2MinusFactory(),
                WGPMModel.i,
                WGPMModel.j,
                WGPMModel.k,
                WGPMModel.ω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // Gap
            this.Gap = resultsAbstractFactory.CreateGapFactory().Create(
                (decimal)solution.Gap)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // I(k, ω)
            this.DayScenarioRecoveryWardCensuses = WGPMModel.I.GetElementsAt(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultElementsAbstractFactory.CreateIResultElementFactory(),
                resultsAbstractFactory.CreateIFactory(),
                WGPMModel.k,
                WGPMModel.ω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // IMax(ω)
            this.ScenarioRecoveryWardCensusMaximums = WGPMModel.IMax.GetElementsAt(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
                resultElementsAbstractFactory.CreateIMaxResultElementFactory(),
                resultsAbstractFactory.CreateIMaxFactory(),
                WGPMModel.ω)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // IMin(ω)
            this.ScenarioRecoveryWardCensusMinimums = WGPMModel.IMin.GetElementsAt(
                dependenciesAbstractFactory.CreateRedBlackTreeFactory(),
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
            Ix x = WGPMModel.x.GetElementsAt(
                resultElementsAbstractFactory.CreatexResultElementFactory(),
                resultsAbstractFactory.CreatexFactory(),
                WGPMModel.i,
                WGPMModel.j,
                WGPMModel.k);

            this.SurgeonOperatingRoomDayAssignments = x
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // SurgeonScenarioNumberPatients
            ISurgeonScenarioNumberPatients surgeonScenarioNumberPatients = calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsCalculationFactory().Create().Calculate(
                resultElementsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementFactory(),
                resultsAbstractFactory.CreateSurgeonScenarioNumberPatientsFactory(),
                calculationsAbstractFactory.CreateSurgeonScenarioNumberPatientsResultElementCalculationFactory().Create(),
                WGPMModel.jk,
                WGPMModel.iω,
                WGPMModel.n,
                x);

            this.SurgeonScenarioNumberPatients = surgeonScenarioNumberPatients.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory(),
                WGPMModel.i,
                WGPMModel.ω);

            // ScenarioNumberPatients(ω)
            this.ScenarioNumberPatients = calculationsAbstractFactory.CreateScenarioNumberPatientsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioNumberPatientsResultElementFactory(),
                resultsAbstractFactory.CreateScenarioNumberPatientsFactory(),
                calculationsAbstractFactory.CreateScenarioNumberPatientsResultElementCalculationFactory().Create(),
                WGPMModel.ω,
                surgeonScenarioNumberPatients)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioTotalTimes(ω)
            IScenarioTotalTimes scenarioTotalTimes = calculationsAbstractFactory.CreateScenarioTotalTimesCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioTotalTimesResultElementFactory(),
                resultsAbstractFactory.CreateScenarioTotalTimesFactory(),
                calculationsAbstractFactory.CreateScenarioTotalTimesResultElementCalculationFactory().Create(),
                WGPMModel.ω,
                WGPMModel.ijk,
                WGPMModel.v,
                x);

            this.ScenarioTotalTimes = scenarioTotalTimes.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioUtilizedTimes(ω)
            IScenarioUtilizedTimes scenarioUtilizedTimes = calculationsAbstractFactory.CreateScenarioUtilizedTimesCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioUtilizedTimesResultElementFactory(),
                resultsAbstractFactory.CreateScenarioUtilizedTimesFactory(),
                calculationsAbstractFactory.CreateScenarioUtilizedTimesResultElementCalculationFactory().Create(),
                WGPMModel.ω,
                WGPMModel.ijk,
                WGPMModel.A,
                WGPMModel.n,
                x);

            this.ScenarioUtilizedTimes = scenarioUtilizedTimes.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioUnutilizedTimes(ω)
            IScenarioUnutilizedTimes scenarioUnutilizedTimes = calculationsAbstractFactory.CreateScenarioUnutilizedTimesCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioUnutilizedTimesResultElementFactory(),
                resultsAbstractFactory.CreateScenarioUnutilizedTimesFactory(),
                calculationsAbstractFactory.CreateScenarioUnutilizedTimesResultElementCalculationFactory().Create(),
                WGPMModel.ω,
                scenarioTotalTimes,
                scenarioUtilizedTimes);

            this.ScenarioUnutilizedTimes = scenarioUnutilizedTimes.GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());

            // ScenarioUnderutilizations(ω)
            this.ScenarioUnderutilizations = calculationsAbstractFactory.CreateScenarioUnderutilizationsCalculationFactory().Create()
                .Calculate(
                resultElementsAbstractFactory.CreateScenarioUnderutilizationsResultElementFactory(),
                resultsAbstractFactory.CreateScenarioUnderutilizationsFactory(),
                calculationsAbstractFactory.CreateScenarioUnderutilizationsResultElementCalculationFactory().Create(),
                WGPMModel.ω,
                scenarioTotalTimes,
                scenarioUnutilizedTimes)
                .GetValueForOutputContext(
                dependenciesAbstractFactory.CreateNullableValueFactory());
        }

        public INullableValue<decimal> BestBound { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioMinusDeviations { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioPlusDeviations { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> SurgeonOperatingRoomDayScenarioDeviations { get; }

        public INullableValue<decimal> Gap { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> DayScenarioRecoveryWardCensuses { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioRecoveryWardCensusMaximums { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioRecoveryWardCensusMinimums { get; }

        public long NumberOfExploredNodes { get; }

        public INullableValue<decimal> ObjectiveValue { get; }

        public TimeSpan OverallWallTime { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<int>> ScenarioNumberPatients { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioTotalTimes { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnderutilizations { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUnutilizedTimes { get; }

        public RedBlackTree<INullableValue<int>, INullableValue<decimal>> ScenarioUtilizedTimes { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> SurgeonScenarioNumberPatients { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> SurgeonOperatingRoomDayAssignments { get; }
    }
}