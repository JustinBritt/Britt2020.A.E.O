namespace Britt2022.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Variables;

    public interface IConstraints1ConstraintElementFactory
    {
        IConstraints1ConstraintElement Create(
            IkIndexElement kIndexElement,
            Iij ij,
            IΠ Π,
            Ix x);
    }
}