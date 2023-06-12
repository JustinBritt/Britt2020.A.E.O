namespace Britt2022.A.E.O.Classes.Parameters.PreferencesOfSurgeons
{
    using log4net;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;

    internal sealed class Π : IΠ
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Π(
            RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, IΠParameterElement>> value)
        {
            this.Value = value;
        }

        public RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, IΠParameterElement>> Value { get; }

        public int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement)
        {
            return this.Value[iIndexElement][jIndexElement].Value.Value.Value ? 1 : 0;
        }
    }
}