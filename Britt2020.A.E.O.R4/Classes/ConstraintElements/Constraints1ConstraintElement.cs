namespace Britt2020.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2020.A.E.O.Interfaces.ConstraintElements;
    using Britt2020.A.E.O.Interfaces.CrossJoins;
    using Britt2020.A.E.O.Interfaces.IndexElements;
    using Britt2020.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2020.A.E.O.Interfaces.Variables;

    internal sealed class Constraints1ConstraintElement : IConstraints1ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints1ConstraintElement(
            IkIndexElement kIndexElement,
            Iij ij,
            IΠ Π,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                ij.Value
                .Select(
                    w => Π.GetElementAtAsint(
                        w.iIndexElement,
                        w.jIndexElement)
                    *
                    x.Value[w.iIndexElement, w.jIndexElement, kIndexElement]));

            int RHS = 0;

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}