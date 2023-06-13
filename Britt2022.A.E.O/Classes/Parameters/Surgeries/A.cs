namespace Britt2022.A.E.O.Classes.Parameters.Surgeries
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;
    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;

    internal sealed class A : IA
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public A(
            RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, IAParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, IAParameterElement>> Value { get; }

        public decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            return this.Value[iIndexElement][ωIndexElement].Value.Value.Value;
        }

        public double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement)
        {
            return (double)this.Value[iIndexElement][ωIndexElement].Value.Value.Value;
        }
    }
}