namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.CrossJoinElements;

    public interface ICrossJoinElementsAbstractFactory
    {
        IieCrossJoinElementFactory CreateieCrossJoinElementFactory();

        IieωCrossJoinElementFactory CreateieωCrossJoinElementFactory();

        IijCrossJoinElementFactory CreateijCrossJoinElementFactory();

        IijkCrossJoinElementFactory CreateijkCrossJoinElementFactory();

        IijkωCrossJoinElementFactory CreateijkωCrossJoinElementFactory();

        IikCrossJoinElementFactory CreateikCrossJoinElementFactory();

        IilCrossJoinElementFactory CreateilCrossJoinElementFactory();

        IiljCrossJoinElementFactory CreateiljCrossJoinElementFactory();

        IilωCrossJoinElementFactory CreateilωCrossJoinElementFactory();

        IiωCrossJoinElementFactory CreateiωCrossJoinElementFactory();

        IjkCrossJoinElementFactory CreatejkCrossJoinElementFactory();

        IkωCrossJoinElementFactory CreatekωCrossJoinElementFactory();
    }
}