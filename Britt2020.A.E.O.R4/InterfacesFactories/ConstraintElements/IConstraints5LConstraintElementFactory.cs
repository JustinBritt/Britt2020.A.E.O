namespace Britt2020.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.Variables;

    public interface IConstraints5LConstraintElementFactory
    {
        IConstraints5LConstraintElement Create(
            IiIndexElement iIndexElement,
            Ijk jk,
            IL L,
            Ix x);
    }
}