namespace Britt2022.A.E.O.Interfaces.Parameters.Surgeries
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.Surgeries;

    public interface IA
    {
        ImmutableList<IAParameterElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);

        double GetElementAtAsdouble(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement);
    }
}