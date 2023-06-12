namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;
    using NGenerics.Patterns.Visitor;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonOperatingRoomAvailabilitiesOuterVisitor<TKey, TValue> : ISurgeonOperatingRoomAvailabilitiesOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<Location, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomAvailabilitiesOuterVisitor(
            IΠParameterElementFactory ΠParameterElementFactory,
            Ii i,
            Ij j)
        {
            this.ΠParameterElementFactory = ΠParameterElementFactory;

            this.i = i;

            this.j = j;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, IΠParameterElement>>();
        }

        private IΠParameterElementFactory ΠParameterElementFactory { get; }

        private Ii i { get; }

        private Ij j { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, IΠParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            RedBlackTree<Location, INullableValue<bool>> value = obj.Value;

            var innerVisitor = new SurgeonOperatingRoomAvailabilitiesInnerVisitor<Location, INullableValue<bool>>(
                this.ΠParameterElementFactory,
                iIndexElement,
                this.j);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}