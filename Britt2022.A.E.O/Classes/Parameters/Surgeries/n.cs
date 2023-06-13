namespace Britt2022.A.E.O.Classes.Parameters.Surgeries
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;

    internal sealed class n : In
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public n(
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, InParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, InParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            return this.Value[iIndexElement][ωIndexElement].Value.Value.Value;
        }
    }
}