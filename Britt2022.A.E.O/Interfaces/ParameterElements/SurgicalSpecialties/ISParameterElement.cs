namespace Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface ISParameterElement
    {
        IrIndexElement rIndexElement { get; }

        ImmutableList<IiIndexElement> Value { get; }
    }
}