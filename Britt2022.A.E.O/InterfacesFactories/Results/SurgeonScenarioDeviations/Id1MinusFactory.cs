namespace Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioDeviations
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioDeviations;

    public interface Id1MinusFactory
    {
        Id1Minus Create(
            ImmutableList<Id1MinusResultElement> value);
    }
}