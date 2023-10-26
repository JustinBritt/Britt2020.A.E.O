namespace Britt2022.A.E.O.Interfaces.Results.ScenarioTotalTimes
{
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using NGenerics.DataStructures.Trees;

    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioTotalTimes;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IScenarioTotalTimes
    {
        ImmutableList<IScenarioTotalTimesResultElement> Value { get; }

        decimal GetElementAtAsdecimal(
            IωIndexElement ωIndexElement);

        RedBlackTree<INullableValue<int>, INullableValue<decimal>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}