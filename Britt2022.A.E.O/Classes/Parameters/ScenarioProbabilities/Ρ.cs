namespace Britt2022.A.E.O.Classes.Parameters.ScenarioProbabilities
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    internal sealed class Ρ : IΡ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ρ(
            RedBlackTree<IωIndexElement, IΡParameterElement> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IωIndexElement, IΡParameterElement> Value { get; }

        public decimal GetElementAtAsdecimal(
            IωIndexElement ωIndexElement)
        {
            return this.Value[ωIndexElement].Value.Value.Value;
        }
    }
}