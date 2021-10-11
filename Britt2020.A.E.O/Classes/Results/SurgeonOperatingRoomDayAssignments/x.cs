namespace Britt2020.A.E.O.Classes.Results.SurgeonOperatingRoomDayAssignments
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayAssignments;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class x : Ix
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public x(
            ImmutableList<IxResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IxResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<bool>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                w => Tuple.Create(
                    w.iIndexElement.Value,
                    w.jIndexElement.Value,
                    w.kIndexElement.Value,
                    nullableValueFactory.Create<bool>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}