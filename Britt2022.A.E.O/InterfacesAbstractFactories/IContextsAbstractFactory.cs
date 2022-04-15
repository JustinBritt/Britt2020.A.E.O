namespace Britt2022.A.E.O.InterfacesAbstractFactories
{
    using Britt2022.A.E.O.InterfacesFactories.Contexts;

    public interface IContextsAbstractFactory
    {
        IWGPMInputContextFactory CreateWGPMInputContextFactory();

        IWGPMOutputContextFactory CreateWGPMOutputContextFactory();
    }
}