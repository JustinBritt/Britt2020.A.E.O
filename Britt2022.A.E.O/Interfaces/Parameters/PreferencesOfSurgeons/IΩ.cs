namespace Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons
{
    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;

    public interface IΩ
    {
        RedBlackTree<IiIndexElement, RedBlackTree<IkIndexElement, IΩParameterElement>> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement);
    }
}