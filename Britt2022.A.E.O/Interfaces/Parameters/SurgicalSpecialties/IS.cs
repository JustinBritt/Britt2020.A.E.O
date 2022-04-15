namespace Britt2022.A.E.O.Interfaces.Parameters.SurgicalSpecialties
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ParameterElements.SurgicalSpecialties;

    public interface IS
    {
        ImmutableList<ISParameterElement> Value { get; }

        bool IsSurgeonMemberOfSurgicalSpecialty(
            IiIndexElement iIndexElement,
            IrIndexElement rIndexElement);
    }
}