namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Solutions;

    public interface ISolutionsAbstractFactory
    {
        IWGPMSolutionFactory CreateWGPMSolutionFactory();
    }
}