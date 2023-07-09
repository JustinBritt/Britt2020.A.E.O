namespace Britt2022.A.E.O.Classes.Results.DayScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.ResultElements.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.DayScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class I : II
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public I(
            ImmutableList<IIResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IIResultElement> Value { get; }

        public ImmutableList<Tuple<FhirDateTime, INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                w => Tuple.Create(
                    w.kIndexElement.Value,
                    w.ωIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                        w.Value)))
                .ToImmutableList();
        }
    }
}