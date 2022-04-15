namespace Britt2022.A.E.O.InterfacesFactories.ParameterElements.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface ISParameterElementFactory
    {
        ISParameterElement Create(
            IrIndexElement rIndexElement,
            ImmutableList<IiIndexElement> value);
    }
}