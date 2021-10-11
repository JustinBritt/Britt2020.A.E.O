namespace Britt2020.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface ISParameterElement
    {
        IrIndexElement rIndexElement { get; }

        ImmutableList<IiIndexElement> Value { get; }
    }
}