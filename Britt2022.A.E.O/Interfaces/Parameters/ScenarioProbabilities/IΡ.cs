namespace Britt2022.A.E.O.Interfaces.Parameters.ScenarioProbabilities
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.ScenarioProbabilities;

    public interface IΡ
    {
        ImmutableList<IΡParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IωIndexElement ωIndexElement);
    }
}