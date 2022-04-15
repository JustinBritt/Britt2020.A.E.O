namespace Britt2022.A.E.O.InterfacesFactories.Parameters.PreferencesOfSurgeons
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;

    public interface IΠFactory
    {
        IΠ Create(
            ImmutableList<IΠParameterElement> value);
    }
}