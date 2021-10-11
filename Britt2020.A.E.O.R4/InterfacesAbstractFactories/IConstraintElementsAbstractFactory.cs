namespace Britt2020.A.E.O.InterfacesAbstractFactories
{
    using Britt2020.A.E.O.InterfacesFactories.ConstraintElements;

    public interface IConstraintElementsAbstractFactory
    {
        IConstraints1ConstraintElementFactory CreateConstraints1ConstraintElementFactory();

        IConstraints2ConstraintElementFactory CreateConstraints2ConstraintElementFactory();

        IConstraints3ConstraintElementFactory CreateConstraints3ConstraintElementFactory();

        IConstraints4ConstraintElementFactory CreateConstraints4ConstraintElementFactory();

        IConstraints5LConstraintElementFactory CreateConstraints5LConstraintElementFactory();

        IConstraints5UConstraintElementFactory CreateConstraints5UConstraintElementFactory();

        IConstraints6ConstraintElementFactory CreateConstraints6ConstraintElementFactory();

        IConstraints7ConstraintElementFactory CreateConstraints7ConstraintElementFactory();

        IConstraints8ConstraintElementFactory CreateConstraints8ConstraintElementFactory();

        IConstraints9ConstraintElementFactory CreateConstraints9ConstraintElementFactory();
    }
}