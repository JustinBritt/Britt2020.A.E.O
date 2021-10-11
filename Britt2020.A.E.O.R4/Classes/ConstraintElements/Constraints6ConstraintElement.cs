namespace Britt2020.A.E.O.Classes.ConstraintElements
{
    using System.Linq;
  
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2020.A.E.O.Interfaces.Variables;

    internal sealed class Constraints6ConstraintElement : IConstraints6ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints6ConstraintElement(
            IiIndexElement iIndexElement,
            IωIndexElement ωIndexElement,
            Ijk jk,
            IN N,
            In n,
            Id1Minus d1Minus,
            Id1Plus d1Plus,
            Ix x)
        {
            Expression LHS =
                n.GetElementAtAsint(
                    iIndexElement,
                    ωIndexElement)
                *
                Expression.Sum(
                    jk.Value
                    .Select(
                    w => x.Value[iIndexElement, w.jIndexElement, w.kIndexElement]))
                +
                d1Minus.Value[iIndexElement, ωIndexElement]
                -
                d1Plus.Value[iIndexElement, ωIndexElement];

            int RHS = N.GetElementAtAsint(
                iIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}