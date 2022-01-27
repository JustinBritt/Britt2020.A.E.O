namespace Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations
{
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;

    public interface Id1PlusResultElementFactory
    {
        Id1PlusResultElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            int value);
    }
}