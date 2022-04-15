namespace Britt2022.A.E.O.Interfaces.CrossJoins
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.CrossJoinElements;

    public interface Ikω
    {
        ImmutableList<IkωCrossJoinElement> Value { get; }
    }
}