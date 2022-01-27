namespace Britt2020.A.E.O.Interfaces.Results.SurgeonScenarioDeviations
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Id1Minus
    {
        ImmutableList<Id1MinusResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}