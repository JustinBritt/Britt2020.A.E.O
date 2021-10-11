namespace Britt2020.A.E.O.InterfacesFactories.Parameters.StrategicTargets
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets;

    public interface IBFactory
    {
        IB Create(
            ImmutableList<IBParameterElement> value);
    }
}