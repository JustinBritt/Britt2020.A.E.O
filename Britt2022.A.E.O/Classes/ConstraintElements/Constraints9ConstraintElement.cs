namespace Britt2022.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.StrategicTargets;
    using Britt2022.A.E.O.Interfaces.Parameters.SurgicalSpecialties;
    using Britt2022.A.E.O.Interfaces.Variables;

    internal sealed class Constraints9ConstraintElement : IConstraints9ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints9ConstraintElement(
            IrIndexElement rIndexElement,
            Iijk ijk,
            IB B,
            IS S,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                ijk.Value
                .Where(
                    w => S.IsSurgeonMemberOfSurgicalSpecialty(
                        w.iIndexElement,
                        rIndexElement))
                .Select(
                    w => x.Value[w.iIndexElement, w.jIndexElement, w.kIndexElement]));

            int RHS = B.GetElementAtAsint(
                rIndexElement);

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}