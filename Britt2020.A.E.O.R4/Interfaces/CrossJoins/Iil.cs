namespace Britt2020.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;

    public interface Iil
    {
        ImmutableList<IilCrossJoinElement> Value { get; }
    }
}