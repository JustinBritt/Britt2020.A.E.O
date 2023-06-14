namespace Britt2022.A.E.O.Classes.Parameters.StrategicTargets
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;

    internal sealed class H : IH
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public H(
            RedBlackTree<IiIndexElement, IHParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, IHParameterElement> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement)
        {
            return this.Value[iIndexElement].Value.Value.Value;
        }
    }
}