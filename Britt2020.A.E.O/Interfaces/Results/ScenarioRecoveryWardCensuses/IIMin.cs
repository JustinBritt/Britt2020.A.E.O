namespace Britt2020.A.E.O.Interfaces.Results.ScenarioRecoveryWardCensuses
{
    using System;
    using System.Collections.Immutable;

    using Hl7.Fhir.Model;

    using Britt2020.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;
    using Britt2020.A.E.O.InterfacesFactories.Dependencies.Hl7.Fhir.R4.Model;

    public interface IIMin
    {
        ImmutableList<IIMinResultElement> Value { get; }

        ImmutableList<Tuple<INullableValue<int>, INullableValue<decimal>>> GetValueForOutputContext(
            INullableValueFactory nullableValueFactory);
    }
}