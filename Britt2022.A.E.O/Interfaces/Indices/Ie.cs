namespace Britt2022.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface Ie
    {
        RedBlackTree<INullableValue<int>, IeIndexElement> Value { get; }

        IeIndexElement GetElementAt(
            INullableValue<int> value);
    }
}