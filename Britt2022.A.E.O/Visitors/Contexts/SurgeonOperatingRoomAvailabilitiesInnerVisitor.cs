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

    internal sealed class SurgeonOperatingRoomAvailabilitiesInnerVisitor<TKey, TValue> : ISurgeonOperatingRoomAvailabilitiesInnerVisitor<TKey, TValue>
        where TKey : Location
        where TValue : INullableValue<bool>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonOperatingRoomAvailabilitiesInnerVisitor(
            IΠParameterElementFactory ΠParameterElementFactory,
            IiIndexElement iIndexElement,
            Ij j)
        {
            this.ΠParameterElementFactory = ΠParameterElementFactory;

            this.iIndexElement = iIndexElement;

            this.j = j;

            this.RedBlackTree = new RedBlackTree<IjIndexElement, IΠParameterElement>();
        }

        private IΠParameterElementFactory ΠParameterElementFactory { get; }

        private IiIndexElement iIndexElement { get; }

        private Ij j { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IjIndexElement, IΠParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IjIndexElement jIndexElement = this.j.GetElementAt(
                obj.Key);

            this.RedBlackTree.Add(
                jIndexElement,
                this.ΠParameterElementFactory.Create(
                    this.iIndexElement,
                    jIndexElement,
                    obj.Value));
        }
    }
}