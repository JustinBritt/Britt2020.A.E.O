namespace Britt2020.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Indices;
    using Britt2020.A.E.O.Interfaces.Variables;

    public interface IConstraints4ConstraintElementFactory
    {
        IConstraints4ConstraintElement Create(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement,
            Ij j,
            Ix x);
    }
}