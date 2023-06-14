namespace Britt2022.A.E.O.Classes.Parameters.StrategicTargets
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;

    internal sealed class B : IB
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public B(
            RedBlackTree<IrIndexElement, IBParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IrIndexElement, IBParameterElement> Value { get; }

        public int GetElementAtAsint(
            IrIndexElement rIndexElement)
        {
            return this.Value[rIndexElement].Value.Value.Value;
        }
    }
}