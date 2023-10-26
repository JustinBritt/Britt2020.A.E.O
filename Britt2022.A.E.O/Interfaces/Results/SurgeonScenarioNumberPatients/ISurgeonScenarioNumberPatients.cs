namespace Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface ISurgeonScenarioNumberPatients
    {
        ImmutableList<ISurgeonScenarioNumberPatientsResultElement> Value { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory,
            Ii i,
            Iω ω);
    }
}