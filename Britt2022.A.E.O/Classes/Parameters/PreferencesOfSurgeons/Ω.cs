namespace Britt2022.A.E.O.Classes.Parameters.PreferencesOfSurgeons
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;

    internal sealed class Ω : IΩ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Ω(
            RedBlackTree<IiIndexElement, RedBlackTree<IkIndexElement, IΩParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IkIndexElement, IΩParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement)
        {
            return this.Value[iIndexElement][kIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}