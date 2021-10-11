namespace Britt2020.A.E.O.InterfacesFactories.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using Britt2020.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface ISFactory
    {
        IS Create(
            ImmutableList<ISParameterElement> value);
    }
}