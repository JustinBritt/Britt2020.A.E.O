namespace Britt2022.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Variables;

    public interface IConstraints5UConstraintElementFactory
    {
        IConstraints5UConstraintElement Create(
            IiIndexElement iIndexElement,
            Ijk jk,
            IH H,
            Ix x);
    }
}