namespace Britt2022.A.E.O.InterfacesFactories.Parameters.LengthsOfStay
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.ParameterElements.LengthsOfStay;

    public interface IΦFactory
    {
        IΦ Create(
            ImmutableList<IΦParameterElement> value);
    }
}