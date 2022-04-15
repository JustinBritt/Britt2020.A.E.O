namespace Britt2022.A.E.O.InterfacesFactories.Parameters.Surgeries
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface IDFactory
    {
        ID Create(
            ImmutableList<IDParameterElement> value);
    }
}