namespace Britt2022.A.E.O.Classes.Parameters.LengthsOfStay
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;

    internal sealed class h : Ih
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public h(
            RedBlackTree<IiIndexElement, IhParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, IhParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            return this.Value[iIndexElement].Value.Value.Value;
        }
    }
}