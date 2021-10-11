namespace Britt2020.A.E.O.InterfacesFactories.Constraints
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.Constraints;

    public interface IConstraints8Factory
    {
        IConstraints8 Create(
            ImmutableList<IConstraints8ConstraintElement> value);
    }
}