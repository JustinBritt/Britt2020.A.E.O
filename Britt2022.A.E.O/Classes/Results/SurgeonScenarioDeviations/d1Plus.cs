namespace Britt2022.A.E.O.Classes.Results.SurgeonScenarioDeviations
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonScenarioDeviations;

    internal sealed class d1Plus : Id1Plus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Plus(
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            Id1PlusOuterVisitor<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>> d1PlusOuterVisitor = new Britt2022.A.E.O.Visitors.Results.SurgeonScenarioDeviations.d1PlusOuterVisitor<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>>(
                nullableValueFactory,
                new Britt2022.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees.RedBlackTreeFactory(),
                new Britt2022.A.E.O.Classes.Comparers.NullableValueintComparer(),
                new Britt2022.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                d1PlusOuterVisitor);

            return d1PlusOuterVisitor.RedBlackTree;
        }
    }
}