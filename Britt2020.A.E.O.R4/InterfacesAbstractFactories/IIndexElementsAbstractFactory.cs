namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.IndexElements;

    public interface IIndexElementsAbstractFactory
    {
        IeIndexElementFactory CreateeIndexElementFactory();

        IiIndexElementFactory CreateiIndexElementFactory();

        IjIndexElementFactory CreatejIndexElementFactory();

        IkIndexElementFactory CreatekIndexElementFactory();

        IlIndexElementFactory CreatelIndexElementFactory();

        IrIndexElementFactory CreaterIndexElementFactory();

        IωIndexElementFactory CreateωIndexElementFactory();
    }
}