namespace Britt2022.A.E.O.Classes.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.Parameters.SurgicalSpecialties;

    internal sealed class S : IS
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public S(
            RedBlackTree<IrIndexElement, ImmutableList<IiIndexElement>> redBlackTree,
            ImmutableList<ISParameterElement> value)
        {
            this.RedBlackTree = redBlackTree;

            this.Value = value;
        }

        private RedBlackTree<IrIndexElement, ImmutableList<IiIndexElement>> RedBlackTree { get; }

        public ImmutableList<ISParameterElement> Value { get; }

        public bool IsSurgeonMemberOfSurgicalSpecialty(
            IiIndexElement iIndexElement,
            IrIndexElement rIndexElement)
        {
            return this.RedBlackTree[rIndexElement]
                .Contains(
                iIndexElement);
        }
    }
}