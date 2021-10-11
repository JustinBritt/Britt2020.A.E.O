namespace Britt2020.A.E.O.InterfacesFactories.ResultElements.SurgeonScenarioDeviations
{
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.SurgeonScenarioDeviations;

    public interface Id1MinusResultElementFactory
    {
        Id1MinusResultElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            decimal value);
    }
}