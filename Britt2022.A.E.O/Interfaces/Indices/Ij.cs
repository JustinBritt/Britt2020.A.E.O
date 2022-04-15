namespace Britt2022.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.IndexElements;

    public interface Ij
    {
        ImmutableList<IjIndexElement> Value { get; }

        IjIndexElement GetElementAt(
            Location value);
    }
}