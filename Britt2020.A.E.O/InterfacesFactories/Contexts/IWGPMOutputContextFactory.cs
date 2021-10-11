namespace Britt2020.A.E.O.InterfacesFactories.Contexts
{
    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.InterfacesAbstractFactories;
    using Britt2020.A.E.O.Interfaces.Contexts;
    using Britt2020.A.E.O.Interfaces.Models;

    public interface IWGPMOutputContextFactory
    {
        IWGPMOutputContext Create(
            IDependenciesAbstractFactory dependenciesAbstractFactory,
            IResultElementsAbstractFactory resultElementsAbstractFactory,
            IResultsAbstractFactory resultsAbstractFactory,
            IWGPMModel WGPMModel,
            Solution solution);
    }
}