namespace Britt2022.A.E.O.Classes.Results.ScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;
    using System.Linq;

    using log4net;

    using Hl7.Fhir.Model;

    using Britt2022.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses;
    using Britt2022.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    internal sealed class IMin : IIMin
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public IMin(
            ImmutableList<IIMinResultElement> value)
        {
            this.Value = value;
        }

        public ImmutableList<IIMinResultElement> Value { get; }

        public ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory)
        {
            return this.Value
                .Select(
                w => Tuple.Create(
                    w.ωIndexElement.Value,
                    nullableValueFactory.Create<decimal>(
                    w.Value)))
                .ToImmutableList();
        }
    }
}