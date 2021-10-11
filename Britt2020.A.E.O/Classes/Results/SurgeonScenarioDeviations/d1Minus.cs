namespace Britt2020.A.E.O.Classes.Results.SurgeonScenarioDeviations
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class d1Minus : Id1Minus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Minus(
            ImmutableList<Id1MinusResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Id1MinusResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                w => Tuple.Create(
                    w.iIndexElement.Value,
                    (INullableValue<int>)w.ωIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                    w.Value)))
                .ToImmutableList();
        }
    }
}