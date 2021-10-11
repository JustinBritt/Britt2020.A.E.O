namespace Britt2020.A.E.O.Classes.Results.SurgeonOperatingRoomDayScenarioDeviations
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.Interfaces.Results.SurgeonOperatingRoomDayScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class d2Minus : Id2Minus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d2Minus(
            ImmutableList<Id2MinusResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Id2MinusResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, Location, FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                w => Tuple.Create(
                    w.iIndexElement.Value,
                    w.jIndexElement.Value,
                    w.kIndexElement.Value,
                    (INullableValue<int>)w.ωIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}