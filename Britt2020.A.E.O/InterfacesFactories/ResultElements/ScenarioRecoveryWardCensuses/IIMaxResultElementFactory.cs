namespace Britt2020.A.E.O.InterfacesFactories.ResultElements.ScenarioRecoveryWardCensuses
{
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.ResultElements.ScenarioRecoveryWardCensuses;

    public interface IIMaxResultElementFactory
    {
        IIMaxResultElement Create(
            IωIndexElement ωIndexElement,
            decimal value);
    }
}