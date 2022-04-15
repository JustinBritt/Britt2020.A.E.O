namespace Britt2022.A.E.O.InterfacesFactories.Parameters.StrategicTargets
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ParameterElements.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;

    public interface ILFactory
    {
        IL Create(
            ImmutableList<ILParameterElement> value);
    }
}