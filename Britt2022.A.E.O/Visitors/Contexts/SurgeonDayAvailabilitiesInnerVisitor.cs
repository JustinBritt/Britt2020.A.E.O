namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonDayAvailabilitiesInnerVisitor<TKey, TValue> : ISurgeonDayAvailabilitiesInnerVisitor<TKey, TValue>
        where TKey : FhirDateTime
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonDayAvailabilitiesInnerVisitor(
            IΩParameterElementFactory ΩParameterElementFactory,
            IiIndexElement iIndexElement,
            Ik k)
        {
            this.ΩParameterElementFactory = ΩParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.k = k;

            this.RedBlackTree = new RedBlackTree<IkIndexElement, IΩParameterElement>();
        }

        private IΩParameterElementFactory ΩParameterElementFactory { get; }

        private IiIndexElement iIndexElement { get; }

        private Ik k { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IkIndexElement, IΩParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IkIndexElement kIndexElement = this.k.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                kIndexElement,
                this.ΩParameterElementFactory.Create(
                    this.iIndexElement,
                    kIndexElement,
                    obj.Value));
        }
    }
}