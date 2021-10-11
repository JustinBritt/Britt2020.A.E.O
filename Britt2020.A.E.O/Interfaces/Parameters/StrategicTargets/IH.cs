namespace Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ParameterElements.StrategicTargets;

    public interface IH
    {
        ImmutableList<IHParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement);
    }
}