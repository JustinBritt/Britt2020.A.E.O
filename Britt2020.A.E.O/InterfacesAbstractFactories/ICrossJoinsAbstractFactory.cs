namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.CrossJoins;

    public interface ICrossJoinsAbstractFactory
    {
        IieFactory CreateieFactory();

        IieωFactory CreateieωFactory();

        IijFactory CreateijFactory();

        IijkFactory CreateijkFactory();

        IijkωFactory CreateijkωFactory();

        IikFactory CreateikFactory();

        IilFactory CreateilFactory();

        IiljFactory CreateiljFactory();

        IilωFactory CreateilωFactory();

        IiωFactory CreateiωFactory();

        IjkFactory CreatejkFactory();

        IkωFactory CreatekωFactory();
    }
}