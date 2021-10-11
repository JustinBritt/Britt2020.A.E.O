namespace Britt2020.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2020.A.E.O.Interfaces.Variables;

    internal sealed class Constraints5UConstraintElement : IConstraints5UConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints5UConstraintElement(
            IiIndexElement iIndexElement,
            Ijk jk,
            IH H,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                jk.Value
                .Select(
                    w => x.Value[iIndexElement, w.jIndexElement, w.kIndexElement]));

            int RHS = H.GetElementAtAsint(
                iIndexElement);

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}