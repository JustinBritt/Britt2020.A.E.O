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

    internal sealed class SurgeonDayAvailabilitiesOuterVisitor<TKey, TValue> : ISurgeonDayAvailabilitiesOuterVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : RedBlackTree<FhirDateTime, INullableValue<bool>>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayAvailabilitiesOuterVisitor(
            IΩParameterElementFactory ΩParameterElementFactory,
            Ii i,
            Ik k)
        {
            this.ΩParameterElementFactory = ΩParameterElementFactory;

            this.i = i;

            this.k = k;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, RedBlackTree<IkIndexElement, IΩParameterElement>>();
        }

        private IΩParameterElementFactory ΩParameterElementFactory { get; }

        private Ii i { get; }

        private Ik k { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, RedBlackTree<IkIndexElement, IΩParameterElement>> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            RedBlackTree<FhirDateTime, INullableValue<bool>> value = obj.Value;

            var innerVisitor = new SurgeonDayAvailabilitiesInnerVisitor<FhirDateTime, INullableValue<bool>>(
                this.ΩParameterElementFactory,
                iIndexElement,
                this.k);

            value.AcceptVisitor(
                innerVisitor);

            this.RedBlackTree.Add(
                iIndexElement,
                innerVisitor.RedBlackTree);
        }
    }
}