namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Models;

    public interface IModelsAbstractFactory
    {
        IWGPMModelFactory CreateWGPMModelFactory();
    }
}