namespace Britt2022.A.E.O.Classes.Parameters.LengthsOfStay
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;

    internal sealed class p : Ip
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public p(
            RedBlackTree<IiIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IpParameterElement>>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IlIndexElement, RedBlackTree<IωIndexElement, IpParameterElement>>> Value { get; }

        public double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IlIndexElement lIndexElement,
            IωIndexElement ωIndexElement)
        {
            return (double)this.Value[iIndexElement][lIndexElement][ωIndexElement].Value.Value.Value;
        }
    }
}