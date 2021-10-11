namespace Britt2020.A.E.O.Classes.ConstraintElements
{
    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.Surgeries;
    using Britt2020.A.E.O.Interfaces.Variables;

    internal sealed class Constraints7ConstraintElement : IConstraints7ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints7ConstraintElement(
            IiIndexElement iIndexElement,
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            IωIndexElement ωIndexElement,
            IA A,
            In n,
            Iv v,
            Id2Minus d2Minus,
            Ix x)
        {
            Expression LHS =
                (A.GetElementAtAsdouble(
                    iIndexElement,
                    ωIndexElement)
                *
                n.GetElementAtAsint(
                    iIndexElement,
                    ωIndexElement)
                -
                (double)v.Value.Value.Value)
                *
                x.Value[iIndexElement, jIndexElement, kIndexElement]
                +
                d2Minus.Value[iIndexElement, jIndexElement, kIndexElement, ωIndexElement];

            int RHS = 0;

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}