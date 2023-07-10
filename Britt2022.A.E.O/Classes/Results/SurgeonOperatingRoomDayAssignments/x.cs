namespace Britt2022.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments
{
    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;
    using Britt2022.A.E.O.InterfacesVisitors.Results.SurgeonOperatingRoomDayAssignments;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>> Value { get; }

        public RedBlackTree<Organization, RedBlackTree<Location, RedBlackTree<FhirDateTime, INullableValue<bool>>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            IxOuterVisitor<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>> xOuterVisitor = new Britt2022.A.E.O.Visitors.Results.SurgeonOperatingRoomDayAssignments.xOuterVisitor<IiIndexElement, RedBlackTree<IjIndexElement, RedBlackTree<IkIndexElement, IxResultElement>>>(
                nullableValueFactory,
                new Britt2022.A.E.O.Classes.Comparers.FhirDateTimeComparer(),
                new Britt2022.A.E.O.Classes.Comparers.LocationComparer(),
                new Britt2022.A.E.O.Classes.Comparers.OrganizationComparer());

            this.Value.AcceptVisitor(
                xOuterVisitor);

            return xOuterVisitor.RedBlackTree;
        }
    }
}