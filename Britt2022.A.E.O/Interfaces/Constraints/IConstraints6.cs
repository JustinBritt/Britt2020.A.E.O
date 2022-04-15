namespace Britt2022.A.E.O.Interfaces.Constraints
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;

    public interface IConstraints6
    {
        ImmutableList<IConstraints6ConstraintElement> Value { get; }
    }
}