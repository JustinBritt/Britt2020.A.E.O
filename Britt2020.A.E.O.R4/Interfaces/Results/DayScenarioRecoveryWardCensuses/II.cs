namespace Britt2020.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface II
    {
        ImmutableList<IIResultElement> Value { get; }

        ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}