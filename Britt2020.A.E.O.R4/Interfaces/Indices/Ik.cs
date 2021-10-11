namespace Britt2020.A.E.O.Interfaces.Indices
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.IndexElements;

    public interface Ik
    {
        ImmutableList<IkIndexElement> Value { get; }

        IkIndexElement GetElementAt(
            int value);

        IkIndexElement GetElementAt(
            FhirDateTime value);

        int GetT();
    }
}