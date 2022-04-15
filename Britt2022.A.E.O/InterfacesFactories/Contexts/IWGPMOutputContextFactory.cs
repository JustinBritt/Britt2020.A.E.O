namespace Britt2022.A.E.O.InterfacesFactories.Contexts
{
    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.InterfacesAbstractFactories;
    using Britt2022.A.E.O.Interfaces.Contexts;
    using Britt2022.A.E.O.Interfaces.Models;

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