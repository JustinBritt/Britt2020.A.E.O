namespace Britt2020.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints6
    {
        ImmutableList<IConstraints6ConstraintElement> Value { get; }
    }
}