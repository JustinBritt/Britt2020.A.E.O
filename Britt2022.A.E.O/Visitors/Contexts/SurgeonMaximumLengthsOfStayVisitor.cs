namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgeonMaximumLengthsOfStayVisitor<TKey, TValue> : ISurgeonMaximumLengthsOfStayVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : INullableValue<int>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgeonMaximumLengthsOfStayVisitor(
            IhParameterElementFactory hParameterElementFactory,
            Ii i)
        {
            this.hParameterElementFactory = hParameterElementFactory;

            this.i = i;

            this.RedBlackTree = new RedBlackTree<IiIndexElement, IhParameterElement>();
        }

        private IhParameterElementFactory hParameterElementFactory { get; }

        private Ii i { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IiIndexElement, IhParameterElement> RedBlackTree { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IiIndexElement iIndexElement = this.i.GetElementAt(
                obj.Key);

            INullableValue<int> value = obj.Value;

            this.RedBlackTree.Add(
                iIndexElement,
                this.hParameterElementFactory.Create(
                    iIndexElement,
                    obj.Value));
        }
    }
}