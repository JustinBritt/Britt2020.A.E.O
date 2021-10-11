namespace Britt2020.A.E.O.Interfaces.Results.SurgeonScenarioDeviations
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Id1Plus
    {
        ImmutableList<Id1PlusResultElement> Value { get; }

        ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}