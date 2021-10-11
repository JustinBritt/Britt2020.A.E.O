namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Variables;

    public interface IVariablesAbstractFactory
    {
        Id1MinusFactory Created1MinusFactory();

        Id1PlusFactory Created1PlusFactory();

        Id2MinusFactory Created2MinusFactory();

        IIFactory CreateIFactory();

        IIMaxFactory CreateIMaxFactory();

        IIMinFactory CreateIMinFactory();

        IxFactory CreatexFactory();
    }
}