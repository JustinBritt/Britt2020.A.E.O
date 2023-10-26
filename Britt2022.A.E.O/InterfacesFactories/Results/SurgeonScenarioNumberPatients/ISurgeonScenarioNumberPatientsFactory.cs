namespace Britt2022.A.E.O.InterfacesFactories.Results.SurgeonScenarioNumberPatients
{
    using System.Collections.Immutable;

    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;
    using Britt2022.A.E.O.Interfaces.Results.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsFactory
    {
        ISurgeonScenarioNumberPatients Create(
            ImmutableList<ISurgeonScenarioNumberPatientsResultElement> value);
    }
}