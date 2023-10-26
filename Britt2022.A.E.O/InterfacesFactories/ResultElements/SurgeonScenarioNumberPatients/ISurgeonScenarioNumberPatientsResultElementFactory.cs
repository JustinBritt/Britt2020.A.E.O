namespace Britt2022.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioNumberPatients
{
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.ResultElements.SurgeonScenarioNumberPatients;

    public interface ISurgeonScenarioNumberPatientsResultElementFactory
    {
        ISurgeonScenarioNumberPatientsResultElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            int value);
    }
}