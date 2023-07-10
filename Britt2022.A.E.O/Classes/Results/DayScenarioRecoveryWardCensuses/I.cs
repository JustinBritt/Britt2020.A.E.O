namespace Britt2022.A.E.O.Classes.Results.DayScenarioRecoveryWardCensuses
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesVisitors.Results.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.IndexElements;

    internal sealed class I : II
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public I(
            RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>> Value { get; }

        public RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IIOuterVisitor<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>> IOuterVisitor = new Britt2022.A.E.O.Visitors.Results.DayScenarioRecoveryWardCensuses.IOuterVisitor<IkIndexElement, RedBlackTree<IωIndexElement, IIResultElement>>(
                nullableValueFactory,
                new Britt2022.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees.RedBlackTreeFactory(),
                new Britt2022.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new Britt2022.A.E.O.Classes.Comparers.NullableValueintComparer());

            this.Value.AcceptVisitor(
                IOuterVisitor);

            return IOuterVisitor.RedBlackTree;
        }
    }
}