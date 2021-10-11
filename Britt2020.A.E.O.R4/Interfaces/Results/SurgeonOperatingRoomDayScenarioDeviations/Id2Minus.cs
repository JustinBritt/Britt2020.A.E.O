namespace Britt2020.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Id2Minus
    {
        ImmutableList<Id2MinusResultElement> Value { get; }

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}