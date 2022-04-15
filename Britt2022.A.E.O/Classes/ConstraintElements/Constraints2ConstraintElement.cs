namespace Britt2022.A.E.O.Classes.ConstraintElements
{
    using System.Linq;

    using log4net;

    using OPTANO.Modeling.Optimization;

    using Britt2022.A.E.O.Interfaces.ConstraintElements;
    using Britt2022.A.E.O.Interfaces.CrossJoins;
    using Britt2022.A.E.O.Interfaces.IndexElements;
    using Britt2022.A.E.O.Interfaces.Parameters.PreferencesOfSurgeons;
    using Britt2022.A.E.O.Interfaces.Variables;

    internal sealed class Constraints2ConstraintElement : IConstraints2ConstraintElement
    {
        private ILog Log => LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Constraints2ConstraintElement(
            IjIndexElement jIndexElement,
            Iik ik,
            IΩ Ω,
            Ix x)
        {
            Expression LHS = Expression.Sum(
                ik.Value
                .Select(
                    w => Ω.GetElementAtAsint(
                        w.iIndexElement,
                        w.kIndexElement)
                    *
                    x.Value[w.iIndexElement, jIndexElement, w.kIndexElement]));

            int RHS = 0;

            this.Value = LHS == RHS;
        }

        public Constraint Value { get; }
    }
}