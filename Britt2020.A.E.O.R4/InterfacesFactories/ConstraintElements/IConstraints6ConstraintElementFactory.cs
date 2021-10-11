namespace Britt2020.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2020.A.E.O.Interfaces.Variables;

    public interface IConstraints6ConstraintElementFactory
    {
        IConstraints6ConstraintElement Create(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            Ijk jk,
            IN N,
            In n,
            Id1Minus d1Minus,
            Id1Plus d1Plus,
            Ix x);
    }
}