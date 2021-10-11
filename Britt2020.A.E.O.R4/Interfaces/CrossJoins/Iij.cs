namespace Britt2020.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.CrossJoinElements;

    public interface Iij
    {
        ImmutableList<IijCrossJoinElement> Value { get; }
    }
}