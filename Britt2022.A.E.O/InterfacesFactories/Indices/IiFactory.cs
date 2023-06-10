namespace Britt2022.A.E.O.InterfacesFactories.Indices
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.Comparers;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;

    public interface IiFactory
    {
        Ii Create(
            IOrganizationComparer organizationComparer,
            ImmutableList<IiIndexElement> value);
    }
}