namespace Britt2022.A.E.O.Visitors.Contexts
{
    using System.Collections.Generic;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.InterfacesVisitors.Contexts;

    internal sealed class SurgicalSpecialtiesVisitor<TKey, TValue> : ISurgicalSpecialtiesVisitor<TKey, TValue>
        where TKey : Organization
        where TValue : IImmutableSet<Organization>
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public SurgicalSpecialtiesVisitor(
            ISParameterElementFactory SParameterElementFactory,
            Ii i,
            Ir r)
        {
            this.SParameterElementFactory = SParameterElementFactory;

            this.i = i;

            this.r = r;

            this.Value = new List<ISParameterElement>();

            this.RedBlackTree = new RedBlackTree<IrIndexElement, ImmutableList<IiIndexElement>>();
        }

        private ISParameterElementFactory SParameterElementFactory { get; }

        private Ii i { get; }

        private Ir r { get; }

        public bool HasCompleted => false;

        public RedBlackTree<IrIndexElement, ImmutableList<IiIndexElement>> RedBlackTree { get; }

        public List<ISParameterElement> Value { get; }

        public void Visit(
            KeyValuePair<TKey, TValue> obj)
        {
            IrIndexElement rIndexElement = this.r.GetElementAt(
                obj.Key);

            ImmutableList<IiIndexElement> value = obj.Value.Select(w => this.i.GetElementAt(w)).ToImmutableList();

            this.RedBlackTree.Add(
                rIndexElement,
                value);

            this.Value.Add(
                this.SParameterElementFactory.Create(
                    rIndexElement,
                    value));
        }
    }
}