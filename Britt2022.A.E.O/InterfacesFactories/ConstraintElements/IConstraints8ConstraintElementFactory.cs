namespace Britt2022.A.E.O.InterfacesFactories.ConstraintElements
{
    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Parameters.LengthsOfStay;
    using Britt2022.A.E.O.Interfaces.Variables;

    public interface IConstraints8ConstraintElementFactory
    {
        IConstraints8ConstraintElement Create(
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            Ik k,
            Il l,
            Iilj ilj,
            IΦ Φ,
            II I,
            Ix x);
    }
}