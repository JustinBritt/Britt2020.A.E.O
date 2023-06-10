namespace Britt2022.A.E.O.Interfaces.Indices
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    
    public interface Iω
    {
        RedBlackTree<INullableValue<int>, IωIndexElement> Value { get; }

        IωIndexElement GetElementAt(
            INullableValue<int> value);
    }
}