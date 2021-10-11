namespace Britt2020.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons
{
    using System.Collections.Immutable;

    using Britt2020.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2020.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;

    public interface IΩFactory
    {
        IΩ Create(
            ImmutableList<IΩParameterElement> value);
    }
}