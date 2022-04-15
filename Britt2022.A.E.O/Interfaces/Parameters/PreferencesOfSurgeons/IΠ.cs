namespace Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.PreferencesOfSurgeons;

    public interface IΠ
    {
        ImmutableList<IΠParameterElement> Value { get; }

        int GetElementAtAsint(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement);
    }
}