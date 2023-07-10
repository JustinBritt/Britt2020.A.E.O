namespace Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioDeviations
{
    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Id1Plus
    {
        RedBlackTree<IiIndexElement, RedBlackTree<IωIndexElement, Id1PlusResultElement>> Value { get; }

        RedBlackTree<Organization, RedBlackTree<INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}