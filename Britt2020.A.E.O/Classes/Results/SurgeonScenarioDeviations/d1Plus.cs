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

    internal sealed class d1Plus : Id1Plus
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public d1Plus(
            ImmutableList<Id1PlusResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<Id1PlusResultElement> Value { get; }

        public ImmutableList<Tuple<Organization, INullableValue<int>, INullableValue<int>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                w => Tuple.Create(
                    w.iIndexElement.Value,
                    (INullableValue<int>)w.ωIndexElement.Value,
                    nullableValueFactory.Create<int>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}