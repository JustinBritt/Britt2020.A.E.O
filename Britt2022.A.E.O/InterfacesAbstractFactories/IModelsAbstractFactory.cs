namespace Britt2022.A.E.O.InterfacesAbstractFactories
{
    using Britt2022.A.E.O.InterfacesFactories.Models;

    public interface IModelsAbstractFactory
    {
        IWGPMModelFactory CreateWGPMModelFactory();
    }
}