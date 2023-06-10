namespace Britt2022.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Indices;
    using Britt2022.A.E.O.Interfaces.Variables;

    internal sealed class Constraints3ConstraintElement : IConstraints3ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints3ConstraintElement(
            IjIndexElement jIndexElement,
            IkIndexElement kIndexElement,
            Ii i,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                i.Value.Values
                .Select(
                    w => x.Value[w, jIndexElement, kIndexElement]));

            int RHS = 1;

            this.Value = LHS <= RHS;
        }

        public Constraint Value { get; }
    }
}