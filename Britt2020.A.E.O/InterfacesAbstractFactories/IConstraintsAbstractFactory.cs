namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.Constraints;

    public interface IConstraintsAbstractFactory
    {
        IConstraints1Factory CreateConstraints1Factory();

        IConstraints2Factory CreateConstraints2Factory();

        IConstraints3Factory CreateConstraints3Factory();

        IConstraints4Factory CreateConstraints4Factory();

        IConstraints5LFactory CreateConstraints5LFactory();

        IConstraints5UFactory CreateConstraints5UFactory();

        IConstraints6Factory CreateConstraints6Factory();

        IConstraints7Factory CreateConstraints7Factory();

        IConstraints8Factory CreateConstraints8Factory();

        IConstraints9Factory CreateConstraints9Factory();
    }
}