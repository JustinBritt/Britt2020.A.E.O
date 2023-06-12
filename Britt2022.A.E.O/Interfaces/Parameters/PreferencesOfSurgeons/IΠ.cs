namespace Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;

    public interface IΠ
    {
        RedBlackTree<IiIndexElement, RedBlackTree<IjIndexElement, IΠParameterElement>> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement);
    }
}