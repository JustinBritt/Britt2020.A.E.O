namespace Britt2020.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface Ix
    {
        ImmutableList<IxResultElement> Value { get; }

        ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}