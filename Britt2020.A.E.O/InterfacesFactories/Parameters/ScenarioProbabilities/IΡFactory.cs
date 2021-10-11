namespace Britt2020.A.E.O.InterfacesFactories.Parameters.ScenarioProbabilities
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;
    using Britt2020.A.E.O.Interfaces.Parameters.ScenarioProbabilities;

    public interface IΡFactory
    {
        IΡ Create(
            ImmutableList<IΡParameterElement> value);
    }
}