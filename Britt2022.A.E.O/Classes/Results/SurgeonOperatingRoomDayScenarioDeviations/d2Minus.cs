namespace Britt2022.A.E.O.Classes.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayScenarioDeviations;

    internal sealed class d2Minus : Id2Minus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2Minus(
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, RedBlackTree<INullableValue<int>, INullableValue<decimal>>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            Id2MinusOuterVisitor<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>> d2MinusOuterVisitor = new Britt2022.A.E.O.Visitors.Results.SurgeonOperatingRoomDayScenarioDeviations.d2MinusOuterVisitor<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, RedBlackTree<IωIndexElement, Id2MinusResultElement>>>>(
                nullableValueFactory,
                new Britt2022.A.E.O.Factories.Dependencies.NGenerics.DataStructures.Trees.RedBlackTreeFactory(),
                new Britt2022.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new Britt2022.A.E.O.Classes.Comparers.LocationComparer(),
                new Britt2022.A.E.O.Classes.Comparers.NullableValueintComparer(),
                new Britt2022.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                d2MinusOuterVisitor);

            return d2MinusOuterVisitor.RedBlackTree;
        }
    }
}