namespace Britt2022.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Variables;

    internal sealed class Constraints4ConstraintElement : IConstraints4ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints4ConstraintElement(
            IiIndexElement iIndexElement,
            IkIndexElement kIndexElement,
            Ij j,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                j.Value
                .Select(
                    w => x.Value[iIndexElement, w, kIndexElement]));

            int RHS = 1;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}