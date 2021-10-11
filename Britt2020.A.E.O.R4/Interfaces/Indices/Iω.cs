namespace Britt2020.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface Iω
    {
        ImmutableList<IωIndexElement> Value { get; }

        IωIndexElement GetElementAt(
            PositiveInt value);
    }
}