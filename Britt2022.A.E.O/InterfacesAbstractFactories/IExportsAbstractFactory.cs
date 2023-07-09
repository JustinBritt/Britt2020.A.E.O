namespace Britt2022.A.E.O.InterfacesAbstractFactories
{
    using Britt2022.A.E.O.InterfacesFactories.Exports;

    public interface IExportsAbstractFactory
    {
        IWGPMExportFactory CreateWGPMExportFactory();
    }
}